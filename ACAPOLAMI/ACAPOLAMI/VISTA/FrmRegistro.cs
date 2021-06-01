using ACAPOLAMI.DAO;
using ACAPOLAMI.DOMINIO;
using ACAPOLAMI.MODELO;
using ACAPOLAMI.NEGOCIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WilianMiranda01.VISTA
{
    public partial class FrmRegistroUsuario : Form
    {
        public FrmRegistroUsuario()
        {
            InitializeComponent();
        }

        ClsButtonColor button = new ClsButtonColor();
        ButtonColor btn = new ButtonColor();

        private void btnCerrarAplicacion_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1 login = new Form1();
            login.Show();
        }

        private void btnMinimizarAplicacion_Click(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }

            else if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnRegistroUsuario_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1 login = new Form1();
            login.Show();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            ClsDUsuarios ClsUsuario = new ClsDUsuarios();
            //cls.SaveDatosUserList(txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtEdad), Convert.ToInt32( txtPass));
            Usuarios usuario = new Usuarios();
            usuario.nombre = txtUsuario.Text;
            usuario.clave = txtPassword.Text;

            String comprobarPass = txtConfirmar.Text;
            if (comprobarPass.Equals(txtPassword.Text))
            {
                ClsUsuario.GuardarUsuario(usuario);

                MessageBox.Show("Registro de usuario exitoso", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 frm = new Form1();
                this.Hide();
                frm.Show();
            }

            else if (txtUsuario.Text == "" && txtPassword.Text == "" && txtConfirmar.Text == "")
            {
                MessageBox.Show("Por favor llene los campos", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else {
                MessageBox.Show("Debe confirmar la contraseña", "No coinciden", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int posX = 0;
        int posY = 0;
        private void pnlCabeceraRegistroUsuario_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }

            else
            {
                Left += (e.X - posX);
                Top += (e.Y - posY);
            }
        }

        private void btnCerrarAplicacion_MouseHover(object sender, EventArgs e)
        {
            btn.BotonRojo = btnCerrarAplicacion;
            button.Rojo(btn);
        }

        private void btnCerrarAplicacion_MouseLeave(object sender, EventArgs e)
        {
            btn.BotonAzulOscuro = btnCerrarAplicacion;
            button.AzulOscuro(btn);
        }

        private void btnCerrarAplicacion_MouseMove(object sender, MouseEventArgs e)
        {
            btn.BotonRojo = btnCerrarAplicacion;
            button.Rojo(btn);
        }
        
        private void btnRegistrarUsuario_MouseHover(object sender, EventArgs e)
        {
            btn.BotonAzulClaro = btnRegistrarUsuario;
            button.AzulClaro(btn);
        }

        private void btnRegistrarUsuario_MouseLeave(object sender, EventArgs e)
        {
            btn.BotonAzulOscuro = btnRegistrarUsuario;
            button.AzulOscuro(btn);
        }

        private void btnRegistrarUsuario_MouseMove(object sender, MouseEventArgs e)
        {
            btn.BotonAzulClaro = btnRegistrarUsuario;
            button.AzulClaro(btn);
        }

        private void btnCancelarRegistro_MouseHover(object sender, EventArgs e)
        {
            btn.BotonAzulClaro = btnCancelarRegistro;
            button.AzulClaro(btn);
        }

        private void btnCancelarRegistro_MouseLeave(object sender, EventArgs e)
        {
            btn.BotonAzulOscuro = btnCancelarRegistro;
            button.AzulOscuro(btn);
        }

        private void btnCancelarRegistro_MouseMove(object sender, MouseEventArgs e)
        {
            btn.BotonAzulClaro = btnCancelarRegistro;
            button.AzulClaro(btn);
        }

        private void btnMinimizarAplicacion_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void chkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPass.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtConfirmar.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtConfirmar.UseSystemPasswordChar = true;
            }
        }

        private void txtConfirmar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && txtUsuario.Text != "" && txtPassword.Text != "" && txtConfirmar.Text != "")
            {
                e.Handled = true;
                btnRegistrarUsuario.PerformClick();
            }

            else if(e.KeyChar == 27)
            {
                e.Handled = true;
                btnCancelarRegistro.PerformClick();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && txtUsuario.Text != "" && txtPassword.Text != "" && txtConfirmar.Text != "")
            {
                e.Handled = true;
                btnRegistrarUsuario.PerformClick();
            }

            else if (e.KeyChar == 27)
            {
                e.Handled = true;
                btnCancelarRegistro.PerformClick();
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && txtUsuario.Text != "" && txtPassword.Text != "" && txtConfirmar.Text != "")
            {
                e.Handled = true;
                btnRegistrarUsuario.PerformClick();
            }

            else if (e.KeyChar == 27)
            {
                e.Handled = true;
                btnCancelarRegistro.PerformClick();
            }
        }
    }
}
