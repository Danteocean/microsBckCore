using Microservice.domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Microservice.infrastructure.Setting;

public class MicroServiceContext: DbContext
{
    public MicroServiceContext(DbContextOptions<MicroServiceContext> options):base(options)
    {
    }

    public virtual DbSet<Unidades>? Unidades { get; set; }
	public virtual DbSet<TipoSuperficie>? TipoSuperficies { get; set; }

	public virtual DbSet<TipoIntervencion>? TipoIntervencions { get; set; }

    public virtual DbSet<Localidad>? Localidad { get; set; }

    public virtual DbSet<ItemPago>? ItemPago { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Unidades>();
		modelBuilder.Entity<TipoSuperficie>();
		modelBuilder.Entity<TipoIntervencion>();
        modelBuilder.Entity<Localidad>();
        modelBuilder.Entity<ItemPago>();
    }
}