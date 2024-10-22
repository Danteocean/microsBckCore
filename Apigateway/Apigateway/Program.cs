using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using System.Text;



var builder = WebApplication.CreateBuilder(args);

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      builder =>
                      {
                          builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
                      });
});

ConfigurationManager configuration = builder.Configuration;
// Add services to the container.



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Configuration.AddJsonFile(path: "ocelot.json", optional: false, reloadOnChange: true);



builder.Services.AddOcelot(builder.Configuration);



builder.Services
    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,

            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
        };
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//CORS
app.UseCors(MyAllowSpecificOrigins);

//Security headers 
app.UseHsts(options => options.MaxAge(days: 365).IncludeSubdomains().Preload().AllResponses());
app.UseXContentTypeOptions();
app.UseReferrerPolicy(opts => opts.NoReferrerWhenDowngrade());
app.UseXXssProtection(options => options.EnabledWithBlockMode());
app.UseXfo(options => options.SameOrigin());
//Feature-Policy
app.Use(async (context, next) =>
{
    context.Response.Headers.Add("Permissions-Policy", "accelerometer = (), camera = (), geolocation = (), gyroscope = (), magnetometer = (), microphone = (), payment = (), usb = ()");
    await next.Invoke();
});

app.UseCsp(opts => opts
    .BlockAllMixedContent()
    .StyleSources(s => s.Self())
    .StyleSources(s => s.UnsafeInline())
    .FontSources(s => s.Self())
    .FormActions(s => s.Self())
    .FrameAncestors(s => s.Self())
    .ImageSources(imageSrc => imageSrc.Self())
    .ImageSources(imageSrc => imageSrc.CustomSources("data:"))
    .ScriptSources(s => s.Self())
);
//End Security Headers

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers().RequireAuthorization("MultipleAuthentication"); // Requiere autenticación utilizando la política "MultipleAuthentication"
});


app.UseOcelot().Wait();

app.Run();