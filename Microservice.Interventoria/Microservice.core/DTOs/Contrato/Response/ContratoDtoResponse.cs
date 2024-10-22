namespace Microservice.core.DTOs.Contrato.Response;

public class ContratoDtoResponse
{
    public String? Localidad { get; set; }

    public String? TipoDeSuperficie { get; set; }

    public String? TipoDeIntervencion { get; set; }

    public DateTime Fecha_inicio { get; set; }

    public DateTime Fecha_Fin { get; set; }

    public String? Direccion { get; set; }
}
