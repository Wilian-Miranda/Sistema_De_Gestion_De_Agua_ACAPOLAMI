using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACAPOLAMI.NEGOCIO
{
    class ClsCalculosPagos
    {
        public string Estado { get; set; }
        public double Pendiente { get; set; }
        public double Impuesto { get; set; }
        public double Acumulado { get; set; }
        /*public double CalcularImpuesto(double pendiente)
        {
            Impuesto = pendiente * 0;
            return Impuesto;
        }*/

        public void CalcularPendiente(double monto, double cancelado)
        {
             Pendiente = monto - cancelado;
        }

        public void CalcularAcumulado()
        {
            Acumulado += Pendiente;
        }

        public void CalculoDePago(double monto, double cancelado,double acumulado)
        {
            Pendiente = 0;
            Acumulado = acumulado;
            //Console.WriteLine("llega" + acumulado);
            Impuesto = 0;
            CalcularPendiente(monto, cancelado);
            CalcularAcumulado();

        }
    }
}
