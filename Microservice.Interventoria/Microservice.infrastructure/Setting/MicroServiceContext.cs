using Microservice.core.Entities;
using Microservice.domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Microservice.infrastructure.Setting;

public class MicroServiceContext: DbContext
{
    public MicroServiceContext(DbContextOptions<MicroServiceContext> options):base(options)
    {
    }

    public virtual DbSet<RegistroVista>? RegistroVistas { get; set; }
	public virtual DbSet<RegistroContrato>? RegistroContratos { get; set; }

	public virtual DbSet<AsignacionContratos>? AsignacionContrato { get; set; }

    public virtual DbSet<ContratoItemPago>? ContratoItemPago { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RegistroVista>();
		modelBuilder.Entity<RegistroContrato>();
		modelBuilder.Entity<AsignacionContratos>();
        modelBuilder.Entity<ContratoItemPago>();
    }
}
