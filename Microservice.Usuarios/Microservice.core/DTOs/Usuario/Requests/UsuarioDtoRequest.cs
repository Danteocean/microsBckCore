namespace Microservice.core.DTOs.Usuario.Requests;

public class UsuarioDtoRequest
{
    public String? usuario { get; set; }

    public String? pass { get; set; }

    public String? nombre { get; set; }

    public String? appelidos { get; set; }

    public Int32 identificacion { get; set; }

    public Int32 rol { get; set; }
}
