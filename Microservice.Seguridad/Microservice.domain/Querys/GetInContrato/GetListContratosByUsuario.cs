
using Dapper;
using Npgsql;
using System.Data.SqlClient;

namespace Microservice.domain.Querys.GetInContrato
{
	public class GetListContratosByUsuario
	{
		private string _conexion = "";
		private int _idUsuario = 0;

		public const string query = @"
						Select c.id_contrato, c.nombre 
						from in_contrato c inner join in_contratoasignacion a 
						on c.id_contrato = a.id_contrato
						where a.id_usuario = @Usuario";

		public GetListContratosByUsuario(string conexion, int idUsuario)
		{
			_conexion = conexion;
			_idUsuario = idUsuario;
		}

		public Object Get()
		{
			Object result = new Object();
			try
			{
				using (var dbConnection = new NpgsqlConnection(_conexion))
				{
					var parameters = new { Usuario = _idUsuario };
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
}
