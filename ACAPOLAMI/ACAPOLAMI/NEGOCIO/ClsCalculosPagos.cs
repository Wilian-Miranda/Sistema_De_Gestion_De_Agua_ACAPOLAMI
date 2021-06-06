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
        public double Total { get; set; }
        public double CalcularImpuesto(double pendiente)
        {
            Impuesto = pendiente * 0.1;
            return Impuesto;
        }

        public double CalcularPendiente(double monto, double cancelado, double total = 0)
        {

             Pendiente = total + monto - cancelado;
             return Pendiente;
        }

        public double CalcularTotal(double monto, double cancelado, double impuesto)
        {   
            Total = CalcularPendiente(monto, cancelado) + impuesto;
            return Total;
        }

        public void CalculoDePago(double monto, double cancelado, double pendiente, double impuesto, double total)
        {

            if (total == 0)
            {
                pendiente = CalcularPendiente(monto, cancelado);

                if (pendiente == 0)
                {
                    Total = 0;
                    Estado = "Cancelado";

                }

                else
                {
                    impuesto = CalcularImpuesto(pendiente);
                    total = CalcularTotal(monto, cancelado, impuesto);
                    Total = total;
                    Estado = "Retrasado";
                }
            }

            else
            {
                pendiente = CalcularPendiente(monto, cancelado, total);

                if (pendiente == 0)
                {
                    Total = 0;
                    Estado = "Cancelado";
                }

                else
                {
                    impuesto = CalcularImpuesto(pendiente);
                    total = CalcularTotal(monto, cancelado, impuesto);
                    Total = total;
                    Estado = "Retrasado";
                }
            }
        }
    }
}
