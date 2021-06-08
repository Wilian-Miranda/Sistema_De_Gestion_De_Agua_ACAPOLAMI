using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACAPOLAMI.VISTA;
using ACAPOLAMI.MODELO;
using ACAPOLAMI.NEGOCIO;
using ACAPOLAMI.DOMINIO;
using ACAPOLAMI.MODELO.ViewModels;
using ACAPOLAMI.DAO;

namespace WilianMiranda01.VISTA
{
    public partial class FrmPagos : Form
    {
        ClsDPagos pagos = new ClsDPagos();
        public FrmPagos()
        {
            InitializeComponent();
        }

        ClsButtonColor button = new ClsButtonColor();
        ButtonColor btn = new ButtonColor();

        private void btnRegistrarPago_MouseHover(object sender, EventArgs e)
        {
            btn.BotonAzulOscuro = btnRegistrarPago;
            button.AzulOscuro(btn);
            btnRegistrarPago.ForeColor = Color.White;
        }

        private void btnRegistrarPago_MouseLeave(object sender, EventArgs e)
        {
            btnRegistrarPago.BackColor = Color.WhiteSmoke;
            btnRegistrarPago.ForeColor = Color.Black;
        }

        private void btnRegistrarPago_MouseMove(object sender, MouseEventArgs e)
        {
            btn.BotonAzulOscuro = btnRegistrarPago;
            button.AzulOscuro(btn);
            btnRegistrarPago.ForeColor = Color.White;
        }

        private void btnModificarPago_MouseHover(object sender, EventArgs e)
        {
            btn.BotonAzulOscuro = btnModificarPago;
            button.AzulOscuro(btn);
            btnModificarPago.ForeColor = Color.White;
        }

        private void btnModificarPago_MouseMove(object sender, MouseEventArgs e)
        {
            btn.BotonAzulOscuro = btnModificarPago;
            button.AzulOscuro(btn);
            btnModificarPago.ForeColor = Color.White;
        }

        private void btnModificarPago_MouseLeave(object sender, EventArgs e)
        {
            btnModificarPago.BackColor = Color.WhiteSmoke;
            btnModificarPago.ForeColor = Color.Black;
        }

        private void btnEliminarPago_MouseHover(object sender, EventArgs e)
        {
            btn.BotonRojo = btnEliminarPago;
            button.Rojo(btn);
            btnEliminarPago.ForeColor = Color.White;
        }

        private void btnEliminarPago_MouseLeave(object sender, EventArgs e)
        {
            btnEliminarPago.BackColor = Color.WhiteSmoke;
            btnEliminarPago.ForeColor = Color.Black;
        }

        private void btnEliminarPago_MouseMove(object sender, MouseEventArgs e)
        {
            btn.BotonRojo = btnEliminarPago;
            button.Rojo(btn);
            btnEliminarPago.ForeColor = Color.White;
        }

        private void btnBuscarConsumidor_MouseHover(object sender, EventArgs e)
        {
            btn.BotonAzulOscuro = btnBuscarConsumidor;
            button.AzulOscuro(btn);
            btnBuscarConsumidor.ForeColor = Color.White;
        }

        private void btnBuscarConsumidor_MouseMove(object sender, MouseEventArgs e)
        {
            btn.BotonAzulOscuro = btnBuscarConsumidor;
            button.AzulOscuro(btn);
            btnBuscarConsumidor.ForeColor = Color.White;
        }

        private void btnBuscarConsumidor_MouseLeave(object sender, EventArgs e)
        {
            btnBuscarConsumidor.BackColor = Color.WhiteSmoke;
            btnBuscarConsumidor.ForeColor = Color.Black;
        }

        private void btnModificarPago_Click(object sender, EventArgs e)
        {
            FrmGestionPagos modificarPago = new FrmGestionPagos();

            if (dtgPagos.SelectedRows.Count > 0)
            {
                modificarPago.txtIdRegistro.Text = dtgPagos.CurrentRow.Cells[0].Value.ToString();

                //cargando datos al formulario del modificar pago
                modificarPago.Id = dtgPagos.CurrentRow.Cells[0].Value.ToString();
                modificarPago.estadoCB = dtgPagos.CurrentRow.Cells[9].Value.ToString();

                String nombres = dtgPagos.CurrentRow.Cells[1].Value.ToString();
                String apellidos = dtgPagos.CurrentRow.Cells[2].Value.ToString();
                modificarPago.nombreNonsumidor = nombres + " " + apellidos;

                modificarPago.txtMontoBase.Text = dtgPagos.CurrentRow.Cells[3].Value.ToString();
                modificarPago.txtCancelado.Text = dtgPagos.CurrentRow.Cells[4].Value.ToString();
                modificarPago.txtPendiente.Text = dtgPagos.CurrentRow.Cells[5].Value.ToString();
                modificarPago.txtImpuesto.Text = dtgPagos.CurrentRow.Cells[6].Value.ToString();
                modificarPago.dtpFechaPago.Text = dtgPagos.CurrentRow.Cells[8].Value.ToString();
                modificarPago.txtTotal.Text = dtgPagos.CurrentRow.Cells[7].Value.ToString();



                modificarPago.pnlBuscador.Enabled = false;

                modificarPago.btnEjecutar.Text = "Actualizar";
                modificarPago.lblEncabezado.Text = "ACTUALIZAR PAGO";


                modificarPago.ShowDialog();
            }
            else
            {
                FrmDialogoError.Error("Primero debe seleccionar el registro que desea modificar");
            }
        }

        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            FrmGestionPagos nuevoPago = new FrmGestionPagos();
            nuevoPago.btnEjecutar.Text = "Insertar";
            nuevoPago.ShowDialog();

        }
        private void btnEliminarPago_Click(object sender, EventArgs e)
        {
            FrmGestionPagos eliminar = new FrmGestionPagos();

            if (dtgPagos.SelectedRows.Count > 0)
            {
                eliminar.txtIdRegistro.Text = dtgPagos.CurrentRow.Cells[0].Value.ToString();

                //cargando datos al formulario del modificar pago
                String nombres = dtgPagos.CurrentRow.Cells[1].Value.ToString();
                String apellidos = dtgPagos.CurrentRow.Cells[2].Value.ToString();
                eliminar.nombreNonsumidor = nombres + " " + apellidos;

                eliminar.txtMontoBase.Text = dtgPagos.CurrentRow.Cells[3].Value.ToString();
                eliminar.txtCancelado.Text = dtgPagos.CurrentRow.Cells[4].Value.ToString();
                eliminar.txtPendiente.Text = dtgPagos.CurrentRow.Cells[5].Value.ToString();
                eliminar.txtImpuesto.Text = dtgPagos.CurrentRow.Cells[6].Value.ToString();
                eliminar.dtpFechaPago.Text = dtgPagos.CurrentRow.Cells[8].Value.ToString();
                eliminar.txtTotal.Text = dtgPagos.CurrentRow.Cells[7].Value.ToString();

                eliminar.estadoCB = dtgPagos.CurrentRow.Cells[9].Value.ToString();

                eliminar.btnEjecutar.Text = "Eliminar";
                eliminar.lblEncabezado.Text = "ELIMINAR PAGO";

                eliminar.pnlBuscador.Enabled = false;
                eliminar.pnlDatosConsumidor.Enabled = false;
                eliminar.pnlDatosPagos.Enabled = false;

                //eliminar.btnEjecutar.Focus();

                eliminar.ShowDialog();
            }
            else
            {
                FrmDialogoError.Error("Primero debe seleccionar el registro que desea eliminar");
            }
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

        private void btnBuscarConsumidor_Click(object sender, EventArgs e)
        {
            if (cbBuscarConsumidor.Text != "")
            {
                Buscador(cbBuscarConsumidor.Text.Trim());
            }

            if (cbBuscarConsumidor.Items.Count > 9)
                cbBuscarConsumidor.Items.RemoveAt(9);

            if (cbBuscarConsumidor.FindString(cbBuscarConsumidor.Text) != -1)
            {
                int index = cbBuscarConsumidor.FindString(cbBuscarConsumidor.Text);
                cbBuscarConsumidor.Items.RemoveAt(index);
                cbBuscarConsumidor.Items.Insert(0, cbBuscarConsumidor.Text);
            }

            //Agregar al historial de busqueda
            else if (cbBuscarConsumidor.SelectedIndex != 0)
                cbBuscarConsumidor.Items.Insert(0, cbBuscarConsumidor.Text);
        }

        private void Buscador(string busqueda = null)
        {
            using (ACAPOLAMIEntities bd = new ACAPOLAMIEntities())
            {
                //Consulta
                IQueryable<PagosViewModel> buscar = (
                    from consumidor in bd.Consumidores
                    from pagos in bd.Pagos
                    from estado in bd.Estados
                    where pagos.idConsumidor_FK == consumidor.idConsumidor 
                    && pagos.idEstado_FK == estado.idEstado

                    select new PagosViewModel
                    {
                        Id = pagos.idPago,
                        Nombres = consumidor.nombresConsumidor,
                        Apellidos = consumidor.apellidosConsumidor,
                        Monto = pagos.monto,
                        Cancelado = pagos.montoCancelado,
                        Pendiente = pagos.montoPendiente,
                        Impuesto = pagos.impuesto,
                        Total = pagos.montoTotal,
                        Fecha = pagos.fechaPago,
                        Estado = estado.nombreEstado
                    });

                //Condicion para que sea diferente de nulo y vacio
                if (busqueda != null && !busqueda.Equals(""))
                {
                    //Empresion lamda para crear las condiciones de busquedas
                    buscar = buscar.Where(d => busqueda == d.Id.ToString() || d.Nombres == busqueda || busqueda == d.Apellidos
                    || d.Monto.ToString() == busqueda || d.Impuesto.ToString() == busqueda || d.Estado == busqueda);
                }

                //Pasamos la lista de consultas al dataGridView

                dtgPagos.DataSource = buscar.ToList();
                
            }
        }
        private void FrmPagos_Load(object sender, EventArgs e)
        {
            Buscador();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Buscador();
        }

        private void cbBuscarConsumidor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && cbBuscarConsumidor.Text != "")
            {
                e.Handled = true;
                btnBuscarConsumidor.PerformClick();
            }
        }

        private void cbBuscarConsumidor_Enter(object sender, EventArgs e)
        {
            cbBuscarConsumidor.SelectAll();
        }
    }
}
