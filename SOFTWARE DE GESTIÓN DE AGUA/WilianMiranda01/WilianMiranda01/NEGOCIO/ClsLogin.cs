using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WilianMiranda01.DOMINIO;

namespace WilianMiranda01.NEGOCIO
{
    class ClsLogin
    {

        public Boolean VerificarUsuario(EntLogin login, EntRegistroUsuario access)
        {
            Boolean a = false;

            //iterando todos los elementos de registro de usuarios
            for (int i = 0; i < access.UsuarioRegistro.Length; i++)
            {
                /*se compara si el usuario almacenado en la matriz UsuarioRegistro
                 es igual al usuario ingresado en el login en el login 
                */
                if (login.Usuario.Equals(access.UsuarioRegistro[i]))
                {
                    /*Si la comparacion del usuario es correcta se compara si 
                     el contraseña almacenada en la matriz PasswordRegistro
                     es igual ala contraseña ingresada en el login 
                    */
                    if (login.Password.Equals(access.PasswordRegistro[i]))
                    {
                        a = true;
                    }

                }
            }

            return a;
        }
    }
}
