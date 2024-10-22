using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Microservice.domain.Entities;
[Table("pa_usuarios")]
public class Usuario
{
    [Key]
    public Int32 id_usuario { get; set; }

    public String? usuario { get; set; }

    public String? pass { get; set; }

    public String? nombre { get; set; }

    public String? appelidos { get; set; }

    public Int32 identificacion { get; set; }

    public Int32 rol { get; set; }
}
