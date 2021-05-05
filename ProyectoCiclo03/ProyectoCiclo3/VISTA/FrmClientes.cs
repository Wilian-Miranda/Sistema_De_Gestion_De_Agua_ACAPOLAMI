using ProyectoCiclo3.DAO;
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
            //Llamada al método 
            ejecutar();
            dtgGestionDeConsumidores.Columns[0].Width = 70;
            dtgGestionDeConsumidores.Columns[1].Width = 180;
            dtgGestionDeConsumidores.Columns[2].Width = 180;
            dtgGestionDeConsumidores.Columns[3].Width = 110;
            dtgGestionDeConsumidores.Columns[4].Width = 200;
            dtgGestionDeConsumidores.Columns[5].Width = 100;

        }
        
        //Método utilizado para leer los datos del sp en el dtgGestionDeConsumidores
        private void ejecutar()
        {
            ClsDMostrarConsumidores mostrarConsumidores = new ClsDMostrarConsumidores();
            dtgGestionDeConsumidores.DataSource = mostrarConsumidores.Consultar();
            btnCantidadDeClientes.Text = dtgGestionDeConsumidores.Rows.Count.ToString();
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
                modificar.comunidad = dtgGestionDeConsumidores.CurrentRow.Cells[6].Value.ToString();

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
        #region Eventos del Mouse de los botones en el formulario
        private void btnBuscar_MouseHover(object sender, EventArgs e)
        {
            btnBuscar.BackColor = Color.Blue;
            btnBuscar.ForeColor = Color.White;
        }

        private void btnBuscar_MouseLeave(object sender, EventArgs e)
        {
            btnBuscar.BackColor = Color.WhiteSmoke;
            btnBuscar.ForeColor = Color.Black;
        }

        private void btnBuscar_MouseMove(object sender, MouseEventArgs e)
        {
            btnBuscar.BackColor = Color.Blue;
            btnBuscar.ForeColor = Color.White;
        }

        private void btnBuscar_MouseUp(object sender, MouseEventArgs e)
        {
            btnBuscar.BackColor = Color.Blue;
            btnBuscar.ForeColor = Color.White;
        }

        private void btnAgregar_MouseHover(object sender, EventArgs e)
        {
            btnAgregar.BackColor = Color.Blue;
            btnAgregar.ForeColor = Color.White;
        }

        private void btnAgregar_MouseLeave(object sender, EventArgs e)
        {
            btnAgregar.BackColor = Color.WhiteSmoke;
            btnAgregar.ForeColor = Color.Black;
        }

        private void btnAgregar_MouseMove(object sender, MouseEventArgs e)
        {
            btnAgregar.BackColor = Color.Blue;
            btnAgregar.ForeColor= Color.White;
        }

        private void btnAgregar_MouseUp(object sender, MouseEventArgs e)
        {
            btnAgregar.BackColor = Color.Blue;
            btnAgregar.ForeColor = Color.White;
        }

        private void btnModificar_MouseHover(object sender, EventArgs e)
        {
            btnModificar.BackColor = Color.Blue;
            btnModificar.ForeColor = Color.White;
        }

        private void btnModificar_MouseLeave(object sender, EventArgs e)
        {
            btnModificar.BackColor = Color.WhiteSmoke;
            btnModificar.ForeColor = Color.Black;
        }

        private void btnModificar_MouseMove(object sender, MouseEventArgs e)
        {
            btnModificar.BackColor = Color.Blue;
            btnModificar.ForeColor = Color.White;
        }

        private void btnModificar_MouseUp(object sender, MouseEventArgs e)
        {
            btnModificar.BackColor = Color.Blue;
            btnModificar.ForeColor = Color.White;
        }

        private void btnEliminar_MouseHover(object sender, EventArgs e)
        {
            ActivarColorRojoBoton(btnEliminar);
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            ActivarColorPorDefecto(btnEliminar);
            
        }

        private void btnEliminar_MouseMove(object sender, MouseEventArgs e)
        {
            ActivarColorRojoBoton(btnEliminar);
        }


        public void ActivarColorAzulBoton(Button boton)
        {
            boton.BackColor = Color.Blue;
            boton.ForeColor = Color.White;
        }
        public void ActivarColorPorDefecto(Button boton)
        {
            boton.BackColor = Color.WhiteSmoke;
            boton.ForeColor = Color.Black;
        }
        public void ActivarColorRojoBoton(Button boton)
        {
            boton.BackColor = Color.Crimson;
            boton.ForeColor = Color.White;
        }
        #endregion
        public void btnRefrescar_Click(object sender, EventArgs e)
        {
            ejecutar();
        }

        private void dtgGestionDeConsumidores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
