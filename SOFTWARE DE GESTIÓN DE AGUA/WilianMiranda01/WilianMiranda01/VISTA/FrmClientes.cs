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
    public partial class FrmClientes : Form
    {
        //FmrPrincipal p = new FmrPrincipal();
        //CCClientes cliente = new CCClientes();
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            //ActualizarDatos();
            //dataGridView1.Columns[0].HeaderText = "CÓDIGO";
            //dataGridView1.Columns[0].Width = 100;
            ////dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //dataGridView1.Columns[1].HeaderText = "APELLIDOS";
            //dataGridView1.Columns[2].HeaderText = "NOMBRES";
            //dataGridView1.Columns[3].HeaderText = "TELÉFONO";
            //dataGridView1.Columns[4].HeaderText = "COMUNIDAD";

            //btnCantidadDeClientes.Text = dataGridView1.Rows.Count.ToString();

        }

        private void ActualizarDatos()
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarClientes clientes = new FrmAgregarClientes();
            clientes.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmModificarCliente modificar = new FrmModificarCliente();
            modificar.txtIdCliente.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            modificar.txtNombre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            modificar.txtApellidos.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            modificar.txtTelefono.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            modificar.txtComunidad.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            modificar.ShowDialog();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FrmEliminarCliente eliminar = new FrmEliminarCliente();

            eliminar.txtIdCliente.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            eliminar.txtNombre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            eliminar.txtApellidos.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            eliminar.txtTelefono.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            eliminar.txtComunidad.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            eliminar.ShowDialog();
        }
    }
}
