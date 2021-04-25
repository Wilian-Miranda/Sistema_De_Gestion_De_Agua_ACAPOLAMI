using System;
using System.Windows.Forms;
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

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            FmrPrincipal frm = new FmrPrincipal();
            frm.Show();
            Visible = false;
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

        private void btnMinimizarVentana(object sender, EventArgs e)
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

        private void btnCerrarVentana(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
