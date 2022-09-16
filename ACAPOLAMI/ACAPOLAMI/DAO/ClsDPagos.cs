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

        public void AgregarPago(decimal monto, decimal cancelado, decimal pendiente, decimal impuesto, DateTime fecha, int estado, int consumidor, Boolean mensaje)
        {
            try
            {
                using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
                {
                    db.sp_InsertarPago(monto, cancelado, pendiente, impuesto, fecha, estado, consumidor);
                    db.SaveChanges();
                    if (mensaje) FrmDialogoExito.Confirmar("Se ha ingresado correctamente ");
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
                    db.SaveChanges();

                    FrmDialogoExito.Confirmar("Se ha eliminado correctamente ");
                }
            }
            catch (Exception ex)
            {
                FrmDialogoError.Error("Ha ocurrido el siguiente error:" + ex.Message.ToString());
            }
        }

        public void Modificarpago(int id, decimal monto, decimal cancelado, decimal pendiente, decimal impuesto,
            DateTime fecha, int estado, int consumidor)
        {
            try
            {
                using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
                {
                    db.sp_ActualizarPago(id, monto, cancelado, pendiente, impuesto, fecha, estado, consumidor);

                    db.SaveChanges();
                    FrmDialogoExito.Confirmar("Se ha actualizado correctamente ");
                    
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en"+ex);
                FrmDialogoError.Error("Ha ocurrido el siguiente error: " + ex.Message.ToString());
            }
        }
        
    }

}

