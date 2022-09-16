using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACAPOLAMI.REPORTE
{
    public class PagosGeneral
    {
        private String nombre;
        private decimal cancelado;
        private decimal pendiente;
        private decimal impuesto;
        private decimal cancelado1;
        private decimal pendiente1;
        private decimal impuesto1;
        private decimal cancelado2;
        private decimal pendiente2;
        private decimal impuesto2;
        private decimal cancelado3;
        private decimal pendiente3;
        private decimal impuesto3;
        private String mes1;
        private String mes2;
        private String mes3;
        private String mes4;
        private int year;

        public PagosGeneral(ReporteGeneralPagos reporte)
        {
            this.Nombre = reporte.Nombre;
            this.Cancelado = (decimal)reporte.Pago1.Cancelado;
            this.Pendiente = (decimal)reporte.Pago1.Pendiente;
            this.Impuesto = (decimal)reporte.Pago1.Impuesto;
            this.Cancelado1 = (decimal)reporte.Pago2.Cancelado;
            this.Pendiente1 = (decimal)reporte.Pago2.Pendiente;
            this.Impuesto1 = (decimal)reporte.Pago2.Impuesto;
            this.Cancelado2 = (decimal)reporte.Pago3.Cancelado;
            this.Pendiente2 = (decimal)reporte.Pago3.Pendiente;
            this.Impuesto2 = (decimal)reporte.Pago3.Impuesto;
            this.Cancelado3 = (decimal)reporte.Pago4.Cancelado;
            this.Pendiente3 = (decimal)reporte.Pago4.Pendiente;
            this.Impuesto3 = (decimal)reporte.Pago4.Impuesto;
            this.mes1 = reporte.Mes1;
            this.mes2 = reporte.Mes2;
            this.mes3 = reporte.Mes3;
            this.mes4 = reporte.Mes4;
            this.year = reporte.Year;
    }

        public string Nombre { get => nombre; set => nombre = value; }
        public decimal Cancelado { get => cancelado; set => cancelado = value; }
        public decimal Pendiente { get => pendiente; set => pendiente = value; }
        public decimal Impuesto { get => impuesto; set => impuesto = value; }
        public decimal Cancelado1 { get => cancelado1; set => cancelado1 = value; }
        public decimal Pendiente1 { get => pendiente1; set => pendiente1 = value; }
        public decimal Impuesto1 { get => impuesto1; set => impuesto1 = value; }
        public decimal Cancelado2 { get => cancelado2; set => cancelado2 = value; }
        public decimal Pendiente2 { get => pendiente2; set => pendiente2 = value; }
        public decimal Impuesto2 { get => impuesto2; set => impuesto2 = value; }
        public decimal Cancelado3 { get => cancelado3; set => cancelado3 = value; }
        public decimal Pendiente3 { get => pendiente3; set => pendiente3 = value; }
        public decimal Impuesto3 { get => impuesto3; set => impuesto3 = value; }
        public string Mes1 { get => mes1; set => mes1 = value; }
        public string Mes2 { get => mes2; set => mes2 = value; }
        public string Mes3 { get => mes3; set => mes3 = value; }
        public string Mes4 { get => mes4; set => mes4 = value; }
        public int Year { get => year; set => year = value; }
    }
}
