using ACAPOLAMI.MODELO;
using System.Collections.Generic;
using System.Linq;

namespace ACAPOLAMI.DAO
{
    class ClsDUsuarios
    {
        public List<Usuarios> CargarUsuario()
        {
            List<Usuarios> listaUsuarios;

            using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {
                listaUsuarios = db.Usuarios.ToList();
            }
            return listaUsuarios;
        }


        public int ComprobarUsuario(Usuarios user)
        {
            int comprobar = 0;
            List<Usuarios> listaUsuario = CargarUsuario();
            
            using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {
                Usuarios Usuarios = new Usuarios();
                    //for (int i = 0; i < list.Count; i++) { 
                    //}
                foreach (var usuario in listaUsuario)
                {
                    if (usuario.nombre.Equals(user.nombre) && usuario.clave.Equals(user.clave))
                    {
                        comprobar = 1;
                    }
                }
            }
            return comprobar;
        }

        public void GuardarUsuario(Usuarios usuario)
        {

            using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {
                Usuarios usuarioDB = new Usuarios();
                usuarioDB.nombre = usuario.nombre;
                usuarioDB.clave = usuario.clave;

                db.Usuarios.Add(usuarioDB);
                db.SaveChanges();
            }
        }
    }
}
