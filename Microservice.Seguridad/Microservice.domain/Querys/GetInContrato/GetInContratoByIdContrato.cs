using Dapper;
using Npgsql;
using System.Data.SqlClient;

namespace Microservice.domain.Querys.GetInContrato;

public class GetInContratoByIdContrato
{
    private String _conexion = "";

    private Int32 _idContrato = 0;

    public const String query = @"
        SELECT PL.descripcion Localidad,PT.descripcion TipoDeSuperficie,PI.descripcion TipoDeIntervencion,
        IC.fecha_inicio Fecha_inicio,IC.fecha_fin Fecha_Fin,IC.direccion Direccion
        FROM public.in_contrato IC
        INNER JOIN public.pa_tiposuperficie PT ON IC.id_tiposuperficie = PT.id_tiposuperficie
        INNER JOIN public.pa_localidad PL ON IC.id_localidad = PL.id_localidad
        INNER JOIN public.pa_tipointervencion PI ON PI.id_tipointertvencion = IC.id_tipointertvencion
        WHERE IC.id_contrato = @idContrato";

    public GetInContratoByIdContrato(string conexion, int idContrato)
    {
        _conexion = conexion;
        _idContrato = idContrato;
    }

    public Object Get()
    {
        Object result = new Object();
        try
        {
            using (var dbConnection = new NpgsqlConnection(_conexion))
            {
                var parameters = new { idContrato = _idContrato };

                result = dbConnection.Query(query, parameters);
            }
            return result;
        }
        catch (Exception ex)
        {
            return null;
        }
    }
}