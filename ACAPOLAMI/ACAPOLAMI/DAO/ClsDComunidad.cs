
using ACAPOLAMI.MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
