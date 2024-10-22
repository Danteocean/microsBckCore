using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservice.core.DTOs.Contrato.Registro
{
	public class RegistroContratoDto
	{
		public Int32 id_contrato { get; set; }

		public Int32 Id_TipoSuperficie { get; set; }

		public Int32 Id_TipoIntervencion { get; set; }

		public Int32 Id_Localidad { get; set; }

		public string Nombre { get; set; }

		public string Direccion { get; set; }

		public DateTime Fecha_Inicio  { get; set; }
		public DateTime Fecha_Fin { get; set; }
		public int IngenieroAsignado { get; set; }

	}
}
