using ACAPOLAMI.DAO;
using ACAPOLAMI.DOMINIO;
using ACAPOLAMI.MODELO;
using ACAPOLAMI.MODELO.ViewModels;
using ACAPOLAMI.NEGOCIO;
using ACAPOLAMI.VISTA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ACAPOLAMI.MODELO.ViewModels.ConsumidoresViewModel;

namespace WilianMiranda01.VISTA
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        ClsButtonColor button = new ClsButtonColor();
        ButtonColor btn = new ButtonColor();

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            //Llamada al método 
            MostrarConsumidores();
            dtgGestionDeConsumidores.Columns[0].Width = 70;
            dtgGestionDeConsumidores.Columns[1].Width = 180;
            dtgGestionDeConsumidores.Columns[2].Width = 180;
            dtgGestionDeConsumidores.Columns[3].Width = 110;
            dtgGestionDeConsumidores.Columns[4].Width = 200;
            dtgGestionDeConsumidores.Columns[5].Width = 100;
        }
        
        //Método utilizado para leer los datos del sp en el dtgGestionDeConsumidores
        private void MostrarConsumidores()
        {
            ClsDConsumidores consumidores = new ClsDConsumidores();
            dtgGestionDeConsumidores.DataSource = consumidores.MostrarConsumidores();
            btnCantidadDeClientes.Text = dtgGestionDeConsumidores.Rows.Count.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmGestionConsumidores agregar = new FrmGestionConsumidores();

            agregar.lblId.Visible = false;
            agregar.txtCodigo.Visible = false;
            agregar.btnEjecutar.Text = "Agregar";

            agregar.ShowDialog();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dtgGestionDeConsumidores.SelectedRows.Count > 0)
            {
                FrmGestionConsumidores modificar = new FrmGestionConsumidores();

                modificar.txtCodigo.Text = dtgGestionDeConsumidores.CurrentRow.Cells[0].Value.ToString();
                modificar.txtNombres.Text = dtgGestionDeConsumidores.CurrentRow.Cells[1].Value.ToString();
                modificar.txtApellidos.Text = dtgGestionDeConsumidores.CurrentRow.Cells[2].Value.ToString();
                modificar.txtDUI.Text = dtgGestionDeConsumidores.CurrentRow.Cells[3].Value.ToString();
                modificar.txtCorreo.Text = dtgGestionDeConsumidores.CurrentRow.Cells[4].Value.ToString();
                modificar.txtTelefono.Text = dtgGestionDeConsumidores.CurrentRow.Cells[5].Value.ToString();

                ///*le decimos que la comunidad de debe aparecer seleccionada
                //debe coincidir con la comunidad del registro del cliente*/
                //esta informacion la carga el formulario a cargarse
                modificar.comunidad = dtgGestionDeConsumidores.CurrentRow.Cells[6].Value.ToString();

                //cambiando el texto del boton ejecutar
                modificar.btnEjecutar.Text = "Modificar";

                modificar.lblEncabezado.ForeColor = Color.RoyalBlue;
                modificar.txtNombres.ForeColor = Color.RoyalBlue;
                modificar.txtApellidos.ForeColor = Color.RoyalBlue;
                modificar.txtDUI.ForeColor = Color.RoyalBlue;
                modificar.txtTelefono.ForeColor = Color.RoyalBlue;
                modificar.txtCorreo.ForeColor = Color.RoyalBlue;


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
                FrmGestionConsumidores eliminar = new FrmGestionConsumidores();
                eliminar.txtCodigo.Text = dtgGestionDeConsumidores.CurrentRow.Cells[0].Value.ToString();
                eliminar.txtNombres.Text = dtgGestionDeConsumidores.CurrentRow.Cells[1].Value.ToString();
                eliminar.txtApellidos.Text = dtgGestionDeConsumidores.CurrentRow.Cells[2].Value.ToString();
                eliminar.txtDUI.Text = dtgGestionDeConsumidores.CurrentRow.Cells[3].Value.ToString();
                eliminar.txtCorreo.Text = dtgGestionDeConsumidores.CurrentRow.Cells[4].Value.ToString();
                eliminar.txtTelefono.Text = dtgGestionDeConsumidores.CurrentRow.Cells[5].Value.ToString();

                ///*le decimos que la comunidad de debe aparecer seleccionada
                //debe coincidir con la comunidad del registro del cliente*/
                //esta informacion la carga el formulario a cargarse
                eliminar.comunidad = dtgGestionDeConsumidores.CurrentRow.Cells[6].Value.ToString();

                //cambiando el texto del boton ejecutar
                eliminar.btnEjecutar.Text = "Eliminar";
                eliminar.lblEncabezado.Text = "ELIMINAR CONSUMIDOR";
                eliminar.pnlDatosConsumidor.Enabled = false;

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
            btn.BotonAzulOscuro = btnBuscar;
            button.AzulOscuro(btn);
            btnBuscar.ForeColor = Color.White;
        }

        private void btnBuscar_MouseLeave(object sender, EventArgs e)
        {
            btnBuscar.BackColor = Color.WhiteSmoke;
            btnBuscar.ForeColor = Color.Black;
        }

        private void btnBuscar_MouseMove(object sender, MouseEventArgs e)
        {
            btn.BotonAzulOscuro = btnBuscar;
            button.AzulOscuro(btn);
            btnBuscar.ForeColor = Color.White;
        }

        private void btnAgregar_MouseHover(object sender, EventArgs e)
        {
            btn.BotonAzulOscuro = btnAgregar;
            button.AzulOscuro(btn);
            btnAgregar.ForeColor = Color.White;
        }

        private void btnAgregar_MouseLeave(object sender, EventArgs e)
        {
            btnAgregar.BackColor = Color.WhiteSmoke;
            btnAgregar.ForeColor = Color.Black;
        }

        private void btnAgregar_MouseMove(object sender, MouseEventArgs e)
        {
            btn.BotonAzulOscuro = btnAgregar;
            button.AzulOscuro(btn);
            btnAgregar.ForeColor = Color.White;
        }

        private void btnModificar_MouseHover(object sender, EventArgs e)
        {
            btn.BotonAzulOscuro = btnModificar;
            button.AzulOscuro(btn);
            btnModificar.ForeColor = Color.White;
        }

        private void btnModificar_MouseLeave(object sender, EventArgs e)
        {
            btnModificar.BackColor = Color.WhiteSmoke;
            btnModificar.ForeColor = Color.Black;
        }

        private void btnModificar_MouseMove(object sender, MouseEventArgs e)
        {
            btn.BotonAzulOscuro = btnModificar;
            button.AzulOscuro(btn);
            btnModificar.ForeColor = Color.White;
        }

        private void btnEliminar_MouseHover(object sender, EventArgs e)
        {
            btn.BotonRojo = btnEliminar;
            button.Rojo(btn);
            btnEliminar.ForeColor = Color.White;
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar.BackColor = Color.WhiteSmoke;
            btnEliminar.ForeColor = Color.Black;
        }

        private void btnEliminar_MouseMove(object sender, MouseEventArgs e)
        {
            btn.BotonRojo = btnEliminar;
            button.Rojo(btn);
            btnEliminar.ForeColor = Color.White;
        }

        #endregion
        public void btnRefrescar_Click(object sender, EventArgs e)
        {
            MostrarConsumidores();
        }

        private void btnRefrescar_MouseHover(object sender, EventArgs e)
        {
            btn.BotonAzulOscuro = btnRefrescar;
            button.AzulOscuro(btn);
            btnRefrescar.ForeColor = Color.White;
        }

        private void btnRefrescar_MouseLeave(object sender, EventArgs e)
        {
            btnRefrescar.BackColor = Color.WhiteSmoke;
            btnRefrescar.ForeColor = Color.Black;
        }

        private void btnRefrescar_MouseMove(object sender, MouseEventArgs e)
        {
            btn.BotonAzulOscuro = btnRefrescar;
            button.AzulOscuro(btn);
            btnRefrescar.ForeColor = Color.White;
        }

        //Evento click para buscar Consumidores
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(cbBuscarCliente.Text != "")
            {
                Buscador(cbBuscarCliente.Text.Trim());
            }

            //Agregar al historial de busqueda
            if(cbBuscarCliente.SelectedIndex != 0)
                cbBuscarCliente.Items.Insert(0, cbBuscarCliente.Text);
        }

        private void Buscador(string busqueda = null)
        {
            using (ACAPOLAMIEntities bd = new ACAPOLAMIEntities())
            {
                //Consulta
                IQueryable<ConsumidoresViewModel> buscar = (
                    from consumidor in bd.Consumidores
                    from comunidad in bd.Comunidades
                    where comunidad.idComunidad == consumidor.idComunidad_FK
                    select new ConsumidoresViewModel
                    {
                        Id = consumidor.idConsumidor,
                        Nombres = consumidor.nombresConsumidor,
                        Apellidos = consumidor.apellidosConsumidor,
                        Dui = consumidor.numeroDocumento,
                        Correo = consumidor.correo,
                        Telefono = consumidor.telefono,
                        Comunidad = comunidad.nombreComunidad
                    });

                //Condicion para que sea diferente de nulo y vacio
                if (busqueda != null && !busqueda.Equals(""))
                {
                    //Empresion lamda para crear las condiciones de busquedas
                    buscar = buscar.Where(d => busqueda == d.Id.ToString() || d.Nombres == busqueda || busqueda == d.Apellidos
                    || busqueda == d.Dui || busqueda == d.Correo || busqueda == d.Telefono
                    || busqueda == d.Comunidad);
                }

                //Pasamos la lista de consultas al dataGridView
                dtgGestionDeConsumidores.DataSource = buscar.ToList();
            }
        }

        private void cbBuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13 && cbBuscarCliente.Text != "")
            {
                e.Handled = true;
                btnBuscar.PerformClick();
            }
        }

        private void cbBuscarCliente_Enter(object sender, EventArgs e)
        {
            cbBuscarCliente.SelectAll();
        }
    }
}
