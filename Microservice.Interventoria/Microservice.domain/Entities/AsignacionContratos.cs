using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Microservice.domain.Entities
{
	[Table("in_contratoasignacion")]
	public class AsignacionContratos
	{
		[Key]
		public int id_asignacion {get; set;}
		public int id_usuario { get; set; }
		public int id_contrato { get; set; }


	}
}
