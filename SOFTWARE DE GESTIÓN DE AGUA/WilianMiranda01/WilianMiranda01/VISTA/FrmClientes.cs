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

            btnCantidadDeClientes.Text = dtgGestionDeConsumidores.Rows.Count.ToString();

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
            if (dtgGestionDeConsumidores.SelectedRows.Count > 0)
            {
                FrmModificarCliente modificar = new FrmModificarCliente();
                modificar.txtIdCliente.Text = dtgGestionDeConsumidores.CurrentRow.Cells[0].Value.ToString();
                modificar.txtNombre.Text = dtgGestionDeConsumidores.CurrentRow.Cells[1].Value.ToString();
                modificar.txtApellidos.Text = dtgGestionDeConsumidores.CurrentRow.Cells[2].Value.ToString();
                modificar.txtDUI.Text = dtgGestionDeConsumidores.CurrentRow.Cells[3].Value.ToString();
                modificar.txtEmail.Text = dtgGestionDeConsumidores.CurrentRow.Cells[4].Value.ToString();
                modificar.txtTelefono.Text = dtgGestionDeConsumidores.CurrentRow.Cells[5].Value.ToString();           
                modificar.cbComunidad.Text = dtgGestionDeConsumidores.CurrentRow.Cells[6].Value.ToString();

                modificar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un registro que desea modificar");
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgGestionDeConsumidores.SelectedRows.Count > 0)
            {
                FrmEliminarCliente eliminar = new FrmEliminarCliente();

                eliminar.txtIdCliente.Text = dtgGestionDeConsumidores.CurrentRow.Cells[0].Value.ToString();
                eliminar.txtNombre.Text = dtgGestionDeConsumidores.CurrentRow.Cells[1].Value.ToString();
                eliminar.txtApellidos.Text = dtgGestionDeConsumidores.CurrentRow.Cells[2].Value.ToString();
                eliminar.txtDUI.Text = dtgGestionDeConsumidores.CurrentRow.Cells[3].Value.ToString();
                eliminar.txtEmail.Text = dtgGestionDeConsumidores.CurrentRow.Cells[4].Value.ToString();
                eliminar.txtTelefono.Text = dtgGestionDeConsumidores.CurrentRow.Cells[5].Value.ToString();
                eliminar.txtComunidad.Text= dtgGestionDeConsumidores.CurrentRow.Cells[6].Value.ToString();

                eliminar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione el registro que desea eliminar");
            }
        }
    }
}
