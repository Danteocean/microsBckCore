using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Microservice.domain.Entities;
[Table("pa_rol")]
public class Rol
{
    [Key]
    public Int32 rol { get; set; }

    public String descripcion { get; set; }

    public DateTime fechacreacion { get; set; }

    public DateTime fechamodificacion { get; set; }

    public Boolean vigente { get; set; }
}
