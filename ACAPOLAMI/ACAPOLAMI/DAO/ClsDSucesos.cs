using ACAPOLAMI.MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACAPOLAMI.DAO
{
    class ClsDSucesos
    {
        //Metodo para traer el ultimo registro ingresado en sucesos
        public Sucesos CargarDatosSucesos()
        {
            using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {
                var listaSucesos = db.Set<Sucesos>()
                .OrderByDescending(t => t.idSuceso)
                .FirstOrDefault();

                return listaSucesos;
            }
        }

        //Metodo para mostrar los ultimos 20 registros ocurridos en sucesos
        public List<Sucesos> CargarSucesos()
        {
            using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {
                var listaSucesos = db.Set<Sucesos>()
                .OrderByDescending(t => t.idSuceso).Take(20).ToList();

                return listaSucesos;
            }
        }

        //Metodo para mostrar todos los sucesos
        public List<Sucesos> CargarHistorial()
        {
            List<Sucesos> listaSucesos = new List<Sucesos>();
            using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {
                listaSucesos = db.Sucesos.ToList();

                return listaSucesos;
            }
        }
    }
}
