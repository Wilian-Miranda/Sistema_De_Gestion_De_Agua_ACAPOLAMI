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
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
