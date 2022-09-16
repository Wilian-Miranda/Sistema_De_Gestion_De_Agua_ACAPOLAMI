using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACAPOLAMI.REPORTE
{
    public class ReporteGeneralPagos
    {
        private String nombre;
        private Pagos pago1;
        private Pagos pago2;
        private Pagos pago3;
        private Pagos pago4;
        private String mes1;
        private String mes2;
        private String mes3;
        private String mes4;
        private int year;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Mes1 { get => mes1; set => mes1 = value; }
        public string Mes2 { get => mes2; set => mes2 = value; }
        public string Mes3 { get => mes3; set => mes3 = value; }
        public string Mes4 { get => mes4; set => mes4 = value; }
        public int Year { get => year; set => year = value; }
        internal Pagos Pago1 { get => pago1; set => pago1 = value; }
        internal Pagos Pago2 { get => pago2; set => pago2 = value; }
        internal Pagos Pago3 { get => pago3; set => pago3 = value; }
        internal Pagos Pago4 { get => pago4; set => pago4 = value; }
    }
}
