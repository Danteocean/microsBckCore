using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Microservice.domain.Entities
{
	[Table("in_contrato")]
	public class RegistroContrato
	{
		[Key]
		public Int32 id_contrato { get; set; }

		public Int32 id_tiposuperficie { get; set; }

		public Int32 id_tipointertvencion { get; set; }

		public Int32 id_localidad { get; set; }

		public string nombre { get; set; }

		public string direccion { get; set; }

		public DateTime fecha_inicio { get; set; }
		public DateTime fecha_fin { get; set; }
	}
}
