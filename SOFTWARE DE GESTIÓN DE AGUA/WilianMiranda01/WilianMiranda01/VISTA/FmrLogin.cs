using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WilianMiranda01.DOMINIO;
using WilianMiranda01.NEGOCIO;
using WilianMiranda01.VISTA;

namespace WilianMiranda01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelarSesion_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            EntLogin User = new EntLogin();
            User.Usuario = txtUsuario.Text;
            User.Password = txtPassword.Text;

            EntRegistroUsuario RegistroUser = new EntRegistroUsuario(); 
            ClsLogin VUser = new ClsLogin();
            FmrPrincipal principalWindow = new FmrPrincipal();

            if (VUser.VerificarUsuario(User,RegistroUser)==true)
            {
                MessageBox.Show("¡Sesión iniciada exitosamente!");
                this.Visible = false;
                principalWindow.Show();

            }
            else
            {
                MessageBox.Show("¡Usuario o contraseña incorrecta!");
                txtUsuario.Text = "";
                txtPassword.Text = "";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if(WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if(WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
