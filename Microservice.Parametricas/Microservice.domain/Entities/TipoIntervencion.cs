using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Microservice.domain.Entities;
[Table("pa_tipointervencion")]
public class TipoIntervencion
{
    [Key]
    public Int32 id_tipointertvencion { get; set; }

    public String? descripcion { get; set; }
}