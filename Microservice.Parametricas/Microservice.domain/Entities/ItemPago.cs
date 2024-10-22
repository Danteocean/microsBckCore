using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Microservice.domain.Entities;
[Table("pa_itempago")]
public class ItemPago
{
    [Key]
    public Int32 id_itempago { get; set; }

    public String? descripcion { get; set; }
}