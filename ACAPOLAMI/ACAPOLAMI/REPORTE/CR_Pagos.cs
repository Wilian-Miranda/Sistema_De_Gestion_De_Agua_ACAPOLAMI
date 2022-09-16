using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACAPOLAMI.REPORTE
{
    public class CR_Pagos
    {
        private int id;
        private String nombres;
        private String apellidos;
        private Decimal monto;
        private Decimal cancelado;
        private Decimal pendiente;
        private Decimal impuesto;
        private DateTime fecha;
        private String estado;

        public CR_Pagos()
        {

        }
        public CR_Pagos(int id, string nombres, string apellidos, 
                        decimal monto, decimal cancelado, decimal pendiente,
                        decimal impuesto, DateTime fecha, string estado)
        {
            this.Id = id;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Monto = monto;
            this.Cancelado = cancelado;
            this.Pendiente = pendiente;
            this.Impuesto = impuesto;
            this.Fecha = fecha;
            this.Estado = estado;
        }

        public int Id { get => id; set => id = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public decimal Monto { get => monto; set => monto = value; }
        public decimal Cancelado { get => cancelado; set => cancelado = value; }
        public decimal Pendiente { get => pendiente; set => pendiente = value; }
        public decimal Impuesto { get => impuesto; set => impuesto = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
