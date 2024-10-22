using Dapper;
using Npgsql;

namespace Microservice.domain.Querys.Login
{
	public class GetListUsers
	{
		private string _conexion = "";

		public const string query = @"
						Select id_usuario, nombre, appelidos
						from pa_usuarios";
		public GetListUsers(string conexion) {
			_conexion = conexion;
		}

		public Object Get()
		{
			Object result = new Object();
			try
			{
				using (var dbConnection = new NpgsqlConnection(_conexion))
				{				

					result = dbConnection.Query(query);
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
