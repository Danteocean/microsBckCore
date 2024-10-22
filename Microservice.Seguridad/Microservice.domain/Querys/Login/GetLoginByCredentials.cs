using Dapper;
using Npgsql;

namespace Microservice.domain.Querys.Login
{
	public class GetLoginByCredentials
	{
		private string _conexion = "";
		private string _user = "";
		private string _pass = "";

		public const string query = @"
						SELECT id_usuario, usuario,rol, nombre, appelidos
						FROM PA_USUARIOS 
						WHERE pass = @pass and usuario= @user";

		public GetLoginByCredentials(string conexion, string user, string pass)
		{
			_conexion = conexion;
			_user = user;
			_pass = pass;	
		}

		public Object Get()
		{
			Object result = new Object();
			try
			{
				using (var dbConnection = new NpgsqlConnection(_conexion))
				{
					var parameters = new { user = _user,pass = _pass  };

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

