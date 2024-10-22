using Dapper;
using Npgsql;

namespace Microservice.domain.Querys.GetListas
{
	public class GetTipoSuperficie
	{ 
		private string _conexion = "";

		public const string query = @"
				Select id_tiposuperficie, descripcion
				from pa_tiposuperficie;";
		public GetTipoSuperficie(string conexion)
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
