using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Microservice.domain.Entities;
[Table("pa_localidads")]
public class Localidad
{
    [Key]
    public Int32 id_localidad { get; set; }

    public String? descripcion { get; set; }
}