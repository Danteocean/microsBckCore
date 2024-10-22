using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Microservice.domain.Entities;
[Table("pa_unidades")]
public class Unidades
{
    [Key]
    public Int32 id_unidad { get; set; }

    public String? descripcion { get; set; }
}