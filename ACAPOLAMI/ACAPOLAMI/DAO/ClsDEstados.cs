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
    class ClsDEstados
    {
        public List<Estados> MostrarEstados()
        {
            List<Estados> estados;

            using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {
                estados = db.Estados.ToList();
            }

            return estados;
        }

        public void GuardarEstado(Estados nombre)
        {
            try
            {
                using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
                {
                    Estados tb_estados = new Estados();

                    tb_estados.nombreEstado = nombre.nombreEstado;

                    db.Estados.Add(tb_estados);
                    db.SaveChanges();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public void EliminarEstado(int id)
        {
            try
            {
                using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
                {
                    int eliminar = Convert.ToInt32(id);
                    Estados estado = db.Estados.Where(x => x.idEstado == eliminar).Select(x => x).FirstOrDefault();

                    db.Estados.Remove(estado);
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
