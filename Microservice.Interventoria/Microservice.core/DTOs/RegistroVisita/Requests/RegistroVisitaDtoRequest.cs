namespace Microservice.core.DTOs.RegistroVisita.Requests;

public class RegistroVisitaDtoRequest
{
        public Int32 id_contrato { get; set; }

        public DateTime fecha_reporte { get; set; }

        public Decimal Largo { get; set; }

        public Decimal Ancho { get; set; }

        public Decimal Espesor { get; set; }

        public Int32 Unidad { get; set; }

        public Int32 id_itemPago { get; set; }
}