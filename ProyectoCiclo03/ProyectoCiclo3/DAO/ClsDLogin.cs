using ProyectoCiclo3.MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCiclo3.DAO
{
    class ClsDLogin
    {
        public List<Usuarios> CargarDatosUser()
        {
            List<Usuarios> Lista;

            using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {
                Lista = db.Usuarios.ToList();
            }
            return Lista;
        }


        public int ComprobarUsuario(Usuarios user)
        {
            int comprobar = 0;
            List<Usuarios> list = CargarDatosUser();
            
            using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {
                Usuarios Usuarios = new Usuarios();
                    //for (int i = 0; i < list.Count; i++) { 
                    //}
                foreach (var iteracion in list)
                {
                    if (iteracion.nombre.Equals(user.nombre) && iteracion.clave.Equals(user.clave))
                    {
                        comprobar = 1;
                    }
                }
            }
            return comprobar;
        }
    }
}
