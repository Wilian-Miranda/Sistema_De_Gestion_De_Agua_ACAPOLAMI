using ACAPOLAMI.MODELO;
using ACAPOLAMI.VISTA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
                var usuarios = (from a in db.Usuarios
                                select a.idUsuarios).ToList();
                if (usuarios.Count == 0)
                {
                    Usuarios usuarioDB = new Usuarios();
                    usuarioDB.nombre = usuario.nombre;
                    usuarioDB.clave = usuario.clave;

                    db.Usuarios.Add(usuarioDB);
                    db.SaveChanges();
                    FrmDialogoExito.Confirmar("Registro de usuario exitoso");
                }
                else
                {
                    new FrmDialogoError("Solo se permite tener un usuario en el sistema. Contacte con el administrador.").ShowDialog();
                }

            }
        }
        public void ActualizarUsuario(Usuarios usuario)
        {

            using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {
                    Usuarios data = db.Usuarios.Where(a => a.idUsuarios == usuario.idUsuarios).FirstOrDefault();
                    data.nombre = usuario.nombre;
                    data.clave = usuario.clave;;
                    db.SaveChanges();

                FrmDialogoExito.Confirmar("El <<nombre del usuario>> se ha modificado con exito");

            }
        }

        public void EliminarUsuario(int id)
        {
            try
            {
                using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
                {
                    int eliminar = Convert.ToInt32(id);
                    Usuarios user = db.Usuarios.Where(x => x.idUsuarios == eliminar).Select(x => x).FirstOrDefault();

                    db.Usuarios.Remove(user);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void CambiarPass(Usuarios user, String newPass)
        {
            List<Usuarios> listaUsuario = CargarUsuario();

            using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {
                foreach (var listUsu in listaUsuario)
                {
                    if (listUsu.nombre.Equals(user.nombre) && listUsu.clave.Equals(user.clave))
                    {
                        int update = user.idUsuarios;
                        Usuarios usu = db.Usuarios.Where(x => x.idUsuarios == update).Select(x => x).FirstOrDefault();
                        usu.clave = newPass;
                        db.SaveChanges();
                        FrmDialogoExito.Confirmar("La <<clave>> se ha modificado con exito");
                    }
                }
            }
        }
    }
}
