using ACAPOLAMI.MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACAPOLAMI.DAO
{
    class ClsDRegistro
    {

        public void SaveDatosUser(Usuarios userU)
        {
  
            using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {
                Usuarios userDB = new Usuarios();
                userDB.nombre = userU.nombre;
                userDB.clave = userU.clave;

                db.Usuarios.Add(userDB);
                db.SaveChanges();
            }
        }
    }
}
