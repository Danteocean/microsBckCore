using Dapper;
using Npgsql;

namespace Microservice.domain.Querys.GetListas
{
	public class GetLocalidad
	{
		private string _conexion = "";

		public const string query = @"
						Select id_localidad, descripcion 
						from pa_localidad";
		public GetLocalidad(string conexion)
		{
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
