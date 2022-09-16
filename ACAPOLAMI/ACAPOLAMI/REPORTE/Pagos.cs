using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACAPOLAMI.REPORTE
{
    internal class Pagos
    {
        private decimal? cancelado;
        private decimal? pendiente;
        private decimal? impuesto;

        public decimal? Cancelado { get => cancelado; set => cancelado = value; }
        public decimal? Pendiente { get => pendiente; set => pendiente = value; }
        public decimal? Impuesto { get => impuesto; set => impuesto = value; }
    }
}
