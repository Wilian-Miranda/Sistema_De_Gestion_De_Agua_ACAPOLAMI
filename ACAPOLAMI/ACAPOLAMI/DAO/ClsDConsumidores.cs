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
    class ClsDConsumidores
    {
        //método que devolvera un listado de tipo sp_MostrarConsumidores_Result
        public List<sp_MostrarConsumidores_Result> MostrarConsumidores()
        {
            //Contexto de datos
            using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {
                //Devolver el contenido como lista
                return db.sp_MostrarConsumidores().ToList();
            }
        }

        public List<Consumidores> ConsultarConsumidores()
        {
            var list = new List<Consumidores>();
            using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {
                list = db.Consumidores.ToList();
            }
            return list;
        }

        //Manda los datos a DAO
        public void InsertarConsumidor(string nombres, string apellidos, string dui, string telefono, string correo, int idComunidad)
        {
            try
            {
                using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
                {
                    db.sp_InsertarConsumidor(nombres, apellidos, dui, telefono, correo, idComunidad);
                    db.SaveChanges();
                    FrmDialogoExito.Confirmar("Se ha ingresado correctamente");
                }
            }

            catch (Exception ex)
            {
                FrmDialogoError.Error("Ha ocurrido el siguiente error: "+ ex.Message.ToString());
            }

        }

        public void EliminarConsumidor(int iD)
        {

            try
            {
                using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
                {
                    db.sp_EliminarConsumidor(iD);
                    db.SaveChanges();
                    FrmDialogoExito.Confirmar("Se ha eliminado correctamente");
                }
            }
            catch (Exception ex)
            {
                FrmDialogoError.Error("Ha ocurrido el siguiente error: "+ ex.Message);
            }
        }

        //Manda los datos a DAO
        public void ActualizarConsumidor(int id, string nombres, string apellidos, string dui, string telefono, int idComunidad, string correo)
        {
            try
            {
                using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
                {
                    db.sp_ActualizarConsumidor(id, nombres, apellidos, dui, telefono, idComunidad, correo);
                    db.SaveChanges();
                    FrmDialogoExito.Confirmar("Se ha actualizado correctamente");
                }

            }
            catch (Exception ex)
            {
                FrmDialogoError.Error("Ha ocurrido el siguiente error: " + ex.Message.ToString());
            }
        }
    }
}
