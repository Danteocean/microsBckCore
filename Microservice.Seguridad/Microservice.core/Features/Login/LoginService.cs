using AutoMapper;
using Microservice.core.Interface.Repositories;
using Microservice.core.Interface.Services;
using Microservice.domain.Querys.Login;
using Microservice.domain.Wrappers;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Microservice.core.Features.Login;

public class LoginService: ILoginService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IConfiguration _configuration;
    private readonly IMapper _mapper;

    public LoginService(IUnitOfWork unitOfWork
            , IConfiguration configuration,
            IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _configuration = configuration;
        _mapper = mapper;
    }

    public async Task<Response<Object>> GetLogin(DTOs.Login.Login login)
    {
        GetLoginByCredentials getLoginByCredentials = new GetLoginByCredentials(_configuration.GetRequiredSection("ConnectionStrings").Value, login.email, login.password);

        object result = getLoginByCredentials.Get();

        if (result == null)
        {
            return new Response<Object> { Estado = "Error", Respuesta = "Error de autenticacion", Succeeded = false };
        }
        else
        {
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);



            var tokeOptions = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: new List<Claim>(),
                expires: DateTime.Now.AddMinutes(6),
                signingCredentials: signinCredentials
            );
            var token = new JwtSecurityTokenHandler().WriteToken(tokeOptions);


            var resultWithToken = new
            {
                DataSession = result,
                TokenString = token
            };

            return new Response<Object>(resultWithToken) { Estado = "Ok", Respuesta = "Success", Succeeded = true };
        }
    }
}
