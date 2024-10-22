namespace Microservice.core.DTOs.Rol.Requests;

public class RolDtoRequestUpdate: RolDtoRequest
{
    public Int32 rol { get; set; }

    public  Boolean vigente { get; set; }
}