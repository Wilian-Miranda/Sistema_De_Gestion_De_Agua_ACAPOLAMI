using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACAPOLAMI.REPORTE
{
    public class CR_ReporteGlobalPorYear
    {
        private int year;
        private decimal monto;
        private decimal cancelado;
        private decimal pendiente;
        private decimal impuesto;

        public CR_ReporteGlobalPorYear(int year, decimal monto, decimal cancelado, decimal pendiente, decimal impuesto)
        {
            this.year = year;
            this.monto = monto;
            this.cancelado = cancelado;
            this.pendiente = pendiente;
            this.impuesto = impuesto;
        }

        public int Year { get => year; set => year = value; }
        public decimal Monto { get => monto; set => monto = value; }
        public decimal Cancelado { get => cancelado; set => cancelado = value; }
        public decimal Pendiente { get => pendiente; set => pendiente = value; }
        public decimal Impuesto { get => impuesto; set => impuesto = value; }
    }
}
