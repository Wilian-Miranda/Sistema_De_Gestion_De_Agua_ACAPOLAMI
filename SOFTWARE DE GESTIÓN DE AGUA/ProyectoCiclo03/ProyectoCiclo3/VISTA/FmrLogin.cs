using System;
using System.Drawing;
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            FrmRegistroUsuario registro = new FrmRegistroUsuario();
            registro.ShowDialog();
        }

        int posX = 0;
        int posY = 0;
        private void panel3_MouseMove(object sender, MouseEventArgs e)
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
            btnCerrarAplicacion.BackColor = Color.Crimson;
        }

        private void btnCerrarAplicacion_MouseLeave(object sender, EventArgs e)
        {
            btnCerrarAplicacion.BackColor = Color.Teal;
        }

        private void btnCerrarAplicacion_MouseMove(object sender, MouseEventArgs e)
        {
            btnCerrarAplicacion.BackColor = Color.Crimson;
        }

        private void btnMinimizarAplicacion_MouseHover(object sender, EventArgs e)
        {
            btnMinimizarAplicacion.BackColor = Color.Cyan;
        }

        private void btnMinimizarAplicacion_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizarAplicacion.BackColor = Color.Teal;
        }

        private void btnMinimizarAplicacion_MouseMove(object sender, MouseEventArgs e)
        {
            btnMinimizarAplicacion.BackColor = Color.Cyan;
        }

        private void btnIniciarSesion_MouseHover(object sender, EventArgs e)
        {
            btnIniciarSesion.BackColor = Color.Blue;
        }

        private void btnIniciarSesion_MouseLeave(object sender, EventArgs e)
        {
            btnIniciarSesion.BackColor = Color.DodgerBlue;
        }

        private void btnIniciarSesion_MouseMove(object sender, MouseEventArgs e)
        {
            btnIniciarSesion.BackColor = Color.Blue;
        }

        private void btnRegistroUsuario_MouseHover(object sender, EventArgs e)
        {
            btnRegistroUsuario.BackColor = Color.Blue;
        }

        private void btnRegistroUsuario_MouseLeave(object sender, EventArgs e)
        {
            btnRegistroUsuario.BackColor = Color.DodgerBlue;
        }

        private void btnRegistroUsuario_MouseMove(object sender, MouseEventArgs e)
        {
            btnRegistroUsuario.BackColor = Color.Blue;
        }
    }
}
