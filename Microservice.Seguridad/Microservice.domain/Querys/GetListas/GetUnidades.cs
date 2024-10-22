using Dapper;
using Npgsql;

namespace Microservice.domain.Querys.GetListas
{
	public class GetUnidades
	{
		private string _conexion = "";

		public const string query = @"
						Select id_unidad, descripcion 
						from pa_unidades";
		public GetUnidades(string conexion)
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
