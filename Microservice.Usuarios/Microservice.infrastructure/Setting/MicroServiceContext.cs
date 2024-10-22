using Microservice.domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Microservice.infrastructure.Setting;

public class MicroServiceContext: DbContext
{
    public MicroServiceContext(DbContextOptions<MicroServiceContext> options):base(options)
    {
    }

    public virtual DbSet<Usuario>? Usuarios { get; set; }
    public virtual DbSet<Rol>? Rol { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>();
        modelBuilder.Entity<Rol>();
    }
}
