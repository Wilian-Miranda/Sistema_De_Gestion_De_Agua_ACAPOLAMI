using ProyectoCiclo3.DAO;
using ProyectoCiclo3.MODELO;
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
    public partial class FrmAgregarClientes : Form
    {
        public FrmAgregarClientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {

                ClsDConsumidores cls = new ClsDConsumidores();

                Consumidores clientes = new Consumidores();

                clientes.nombresConsumidor = txtNombreNuevoCliente.Text;
                clientes.apellidosConsumidor = txtApellidos.Text;
                clientes.numeroDocumento = txtDUI.Text;
                clientes.telefono = txtDUI.Text;
                clientes.correo = txtEmail.Text;
                clientes.idComunidad_FK = Convert.ToInt32(cbComunidad.Text);


                cls.InsertarUsuario(clientes);



            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        int posX = 0;
        int posY = 0;
        private void pnlCabeceraAgregarCliente_MouseMove(object sender, MouseEventArgs e)
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

        private void btnAgregar_MouseHover(object sender, EventArgs e)
        {
            btnAgregar.BackColor = Color.FromArgb(0, 64, 64);        }

        private void btnAgregar_MouseLeave(object sender, EventArgs e)
        {
            btnAgregar.BackColor = Color.DarkCyan;
        }

        private void btnAgregar_MouseMove(object sender, MouseEventArgs e)
        {
            btnAgregar.BackColor = Color.FromArgb(0, 64, 64);
        }

        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.FromArgb(0, 64, 64);
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.DarkCyan;
        }

        private void btnCancelar_MouseMove(object sender, MouseEventArgs e)
        {
            btnCancelar.BackColor = Color.FromArgb(0, 64, 64);
        }
    }
}
