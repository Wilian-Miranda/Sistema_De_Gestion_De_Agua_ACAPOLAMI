using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WilianMiranda01.DOMINIO
{
    class EntRegistroUsuario
    {

        //Definiendo atributos del registro de usuarios
        //cuando la contraseña llegue aqui se habrá comparado anteriormente
        private String[] usuarioRegistro= {"José", "William", "Will", "Sandra", "Rosa"};
        private String[] passwordRegistro = {"1234", "1111", "0000", "9999", "8888"};

        public string[] UsuarioRegistro { get => usuarioRegistro; set => usuarioRegistro = value; }
        public string[] PasswordRegistro { get => passwordRegistro; set => passwordRegistro = value; }
    }
}
