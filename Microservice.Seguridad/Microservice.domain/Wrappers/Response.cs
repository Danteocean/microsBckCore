namespace Microservice.domain.Wrappers;

public class Response<T>
{
    public Response()
    {
    }

    public Response(T data)
    {
        Estado = String.Empty;
        Respuesta = String.Empty;
        Succeeded = true;
        Data = data;

    }

    public String Estado { get; set; }

    public String Respuesta { get; set; }

    public Boolean Succeeded { get; set; }

    public T? Data { get; set; }
}