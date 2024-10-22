using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Microservice.core.Entities;

[Table("in_registrovisita")]
public class RegistroVista
{
    [Key]
    public Int32 id_registrovisita { get; set; }

    public Int32 id_contrato { get; set; }

    public Int32 id_itempago { get; set; }

    public Decimal largo { get; set; }

    public Decimal ancho { get; set; }

    public Decimal espesor { get; set; }

    public Int32 unidad { get; set; }

    public DateTime fecha_reporte { get; set; }
}