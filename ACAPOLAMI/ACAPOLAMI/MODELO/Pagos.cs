//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ACAPOLAMI.MODELO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pagos
    {
        public int idPago { get; set; }
        public decimal monto { get; set; }
        public Nullable<decimal> montoCancelado { get; set; }
        public Nullable<decimal> montoPendiente { get; set; }
        public Nullable<decimal> impuesto { get; set; }
        public Nullable<decimal> montoTotal { get; set; }
        public System.DateTime fechaPago { get; set; }
        public Nullable<int> idEstado_FK { get; set; }
        public Nullable<int> idConsumidor_FK { get; set; }
    
        public virtual Consumidores Consumidores { get; set; }
        public virtual Estados Estados { get; set; }
    }
}
