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
    
    public partial class sp_MostrarPagos_Result
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public decimal Monto { get; set; }
        public Nullable<decimal> Cancelado { get; set; }
        public Nullable<decimal> Pendiente { get; set; }
        public Nullable<decimal> Impuesto { get; set; }
        public string Estado { get; set; }
        public System.DateTime Fecha { get; set; }
    }
}
