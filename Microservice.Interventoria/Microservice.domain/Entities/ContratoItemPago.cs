using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Microservice.domain.Entities;
[Table("in_contratoitempago")]
public class ContratoItemPago
{
    [Key]
    public Int32 idconasgi { get; set; }

    public Int32 id_itempago { get; set; }

    public Int32 id_contrato { get; set; }
}