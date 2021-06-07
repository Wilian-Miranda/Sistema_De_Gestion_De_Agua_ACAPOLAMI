using ACAPOLAMI.MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACAPOLAMI.DAO
{
    class ClsDComunidad
    {
        public List<Comunidades> ConsultarComunidades()
        {
            List<Comunidades> lista = new List<Comunidades>();
            using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {
                lista = db.Comunidades.ToList();
                
            }
            return lista;
        }

        public void GuardarComunidades(string nombreComunidad)
        {
            try
            {
                using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
                {
                    db.sp_InsertarComunidad(nombreComunidad);
                    db.SaveChanges();

                    MessageBox.Show("Se guardó existosamente");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        //public void ElimiarComunidades(int idComunidad)
        //{
        //    try
        //    {
        //        using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
        //        {
        //            db.sp_EliminarComunidad(idComunidad);
        //            db.SaveChanges();

        //            MessageBox.Show("La comunidad se eliminó exitosamente");
        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //}
    }
}
