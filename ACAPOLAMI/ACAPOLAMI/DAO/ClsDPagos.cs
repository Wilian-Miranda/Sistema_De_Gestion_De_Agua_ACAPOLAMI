using ACAPOLAMI.MODELO;
using ACAPOLAMI.VISTA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACAPOLAMI.DAO
{
    class ClsDPagos
    {
        public List<Pagos> MostrarPagos()
        {
            var listaPagos = new List<Pagos>();
            using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {
                listaPagos = db.Pagos.ToList();
            }
            return listaPagos;
        }

        public void AgregarPago(decimal monto, decimal cancelado, decimal pendiente, decimal impuesto,
            decimal total, DateTime fecha, int estado, int consumidor)
        {
            try
            {
                using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
                {
                    db.sp_InsertarPago(monto, cancelado, pendiente, impuesto, total, fecha, estado, consumidor);
                    db.SaveChanges();

                    FrmDialogoExito.Confirmar("Se ha ingresado correctamente ");
                }
            }
            catch (Exception ex)
            {
                FrmDialogoError.Error("Ha ocurrido el siguiente error: " + ex.Message.ToString());
            }

        }
        public void EliminarPago(int id)
        {
            try
            {
                using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
                {
                    db.sp_EliminarPago(id);

                    FrmDialogoExito.Confirmar("Se ha eliminado correctamente ");
                }
            }
            catch (Exception ex)
            {
                FrmDialogoError.Error("Ha ocurrido el siguiente error: " + ex.Message.ToString());
            }
        }

        public void Modificarpago(int id, decimal monto, decimal cancelado, decimal pendiente, decimal impuesto,
            decimal total, DateTime fecha, int estado, int consumidor)
        {
            try
            {
                using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
                {
                    db.sp_ActualizarPago(id, monto, cancelado, pendiente, impuesto, total, fecha, estado, consumidor);

                    db.SaveChanges();
                    FrmDialogoExito.Confirmar("Se ha actualizado correctamente ");
                }

            }
            catch (Exception ex)
            {
                FrmDialogoError.Error("Ha ocurrido el siguiente error: " + ex.Message.ToString());
            }
        }
        public List<String> CargarAnio()
        {
            List<String> listFecha = new List<string>();
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    String ultimaFecha = "";
                    foreach (var k in listFecha)
                    {
                        ultimaFecha = k;
                    }

                    if (ultimaFecha == "2021")
                    {
                        break;

                    }
                    else
                    {
                        if (j == 10)
                        {
                            if (i == 1)
                            {
                                listFecha.Add("2" + (i - 1).ToString() + (j + 10).ToString());
                            }
                            else
                            {
                                listFecha.Add("2" + i.ToString() + j.ToString());
                            }
                        }

                        else
                        {
                            listFecha.Add("20" + i.ToString() + j.ToString());
                        }
                    }
                }
            }
            return listFecha;
        }
    }

}

