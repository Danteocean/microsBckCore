using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Microservice.domain.Entities;
[Table("pa_tiposuperficie")]
public class TipoSuperficie
{
    [Key]
    public Int32 id_tiposuperficie { get; set; }

    public String descripcion { get; set; }
}