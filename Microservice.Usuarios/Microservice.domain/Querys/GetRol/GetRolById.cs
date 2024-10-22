using Dapper;
using Microservice.domain.Entities;
using Npgsql;

namespace Microservice.domain.Querys.GetRol;

public class GetRolById
{
    private String _conexion = "";

    private Int32 _rol;

    public const string query = @"SELECT rol, descripcion, fechacreacion, fechamodificacion, vigente
	FROM public.pa_rol WHERE rol = @rol;";

    public GetRolById(String conexion, Int32 rol)
    {
        _conexion =conexion;
        _rol = rol;
    }

    public Rol GetRol()
    {
        Rol rol = new Rol();
        try
        {
            using (var dbConnection = new NpgsqlConnection(_conexion))
            {
                var parameters = new { rol = _rol };

                rol = (Rol)dbConnection.Query(query, parameters);
            }
            return rol;
        }
        catch (Exception ex)
        {
            return null;
        }
    }
}
