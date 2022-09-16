using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACAPOLAMI.MODELO;
using ACAPOLAMI.NEGOCIO;
using ACAPOLAMI.DOMINIO;
using ACAPOLAMI.MODELO.ViewModels;
using ACAPOLAMI.DAO;

namespace ACAPOLAMI.VISTA
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
            btnRegistrarPago.BackColor = Color.White;
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
            btnModificarPago.BackColor = Color.White;
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
            btnEliminarPago.BackColor = Color.White;
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
            btnBuscarConsumidor.BackColor = Color.White;
            btnBuscarConsumidor.ForeColor = Color.Black;
        }

        private void btnModificarPago_Click(object sender, EventArgs e)
        {
            FrmGestionPagos modificarPago = new FrmGestionPagos();

            if (dtgPagos.SelectedRows.Count > 0)
            {
                modificarPago.txtIdRegistro.Text = dtgPagos.CurrentRow.Cells[0].Value.ToString();

                //cargando datos al formulario del modificar pago
                modificarPago.IdRegistroPago = dtgPagos.CurrentRow.Cells[0].Value.ToString();
                modificarPago.estadoCB = dtgPagos.CurrentRow.Cells[8].Value.ToString();

                String nombres = dtgPagos.CurrentRow.Cells[1].Value.ToString();
                String apellidos = dtgPagos.CurrentRow.Cells[2].Value.ToString();
                modificarPago.nombreNonsumidor = nombres + " " + apellidos;

                modificarPago.txtMontoBase.Text = dtgPagos.CurrentRow.Cells[3].Value.ToString().Replace(",", ".");
                modificarPago.txtCancelado.Text = dtgPagos.CurrentRow.Cells[4].Value.ToString().Replace(",",".");
                modificarPago.txtPendiente.Text = dtgPagos.CurrentRow.Cells[5].Value.ToString().Replace(",", ".");
                modificarPago.txtImpuesto.Text = dtgPagos.CurrentRow.Cells[6].Value.ToString().Replace(",", ".");
                modificarPago.dtpFechaPago.Text = dtgPagos.CurrentRow.Cells[7].Value.ToString();
                //eliminar.txtAcumulado.Text = dtgPagos.CurrentRow.Cells[7].Value.ToString();

                modificarPago.estadoCB = dtgPagos.CurrentRow.Cells[8].Value.ToString();



                modificarPago.pnlBuscador.Enabled = false;

                modificarPago.btnEjecutar.Text = "Actualizar";
                modificarPago.lblEncabezado.Text = "ACTUALIZAR PAGO";

                modificarPago.ventanaActualPagos = this;

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
            nuevoPago.ventanaActualPagos = this;
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
                eliminar.dtpFechaPago.Text = dtgPagos.CurrentRow.Cells[7].Value.ToString();
                eliminar.estadoCB = dtgPagos.CurrentRow.Cells[8].Value.ToString();

                eliminar.btnEjecutar.Text = "Eliminar";
                eliminar.lblEncabezado.Text = "ELIMINAR PAGO";

                eliminar.pnlBuscador.Enabled = false;
                eliminar.pnlDatosConsumidor.Enabled = false;
                eliminar.pnlDatosPagos.Enabled = false;

                eliminar.ventanaActualPagos = this;

                eliminar.ShowDialog();
            }
            else
            {
                FrmDialogoError.Error("Primero debe seleccionar el registro que desea eliminar");
            }
        }

        private void btnBuscarConsumidor_Click(object sender, EventArgs e)
        {
            if (cbBuscarConsumidor.Text.Trim().Length > 0)
            {
                if (cbBuscarConsumidor.Text.Contains("_"))
                {
                    Buscador(1, cbBuscarConsumidor.Text);
                }
                else
                {
                    Buscador(0, cbBuscarConsumidor.Text.Trim());
                }
            }
            else
            {
                Buscador(0, cbBuscarConsumidor.Text.Trim());
            }
            /*
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
                cbBuscarConsumidor.Items.Insert(0, cbBuscarConsumidor.Text);*/
        }

        public void Buscador(int tipo,string busqueda = null)
        {
            List<PagosViewModel> filtrado = new List<PagosViewModel>();
            IQueryable<PagosViewModel> buscar;
            using (ACAPOLAMIEntities bd = new ACAPOLAMIEntities())
            {
                //Consulta
                buscar = (
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
                        Fecha = pagos.fechaPago,
                        Estado = estado.nombreEstado
                    });

                //Condicion para que sea diferente de nulo y vacio
                if (busqueda != null && !busqueda.Equals("") && tipo == 0)
                {
                    Console.WriteLine("Tipo: "+busqueda.GetType().Name +" Valor: "+busqueda.ToString()+" Filtro: 1");
                    //Empresion lamda para crear las condiciones de busquedas
                    filtrado = buscar.Where(d => busqueda.ToLower() == d.Nombres.ToLower() ||
                    busqueda.ToLower() == d.Apellidos.ToLower() || busqueda.ToLower() == (d.Nombres + " " + d.Apellidos).ToLower()
                    || busqueda == d.Estado.ToLower()).ToList();

                }
                else if (busqueda == null && tipo == 0)
                {
                    Console.WriteLine(" Filtro: 2");

                    //Empresion lamda para crear las condiciones de busquedas
                    filtrado = buscar.ToList();
                }
                else if (busqueda != null && !busqueda.Equals("") && tipo == 1)
                {
                    String nombre = busqueda.Split('_')[0];
                    String year = busqueda.Split('_')[1];
                    foreach (var i in buscar)
                    {
                        //Console.WriteLine(i.Fecha);
                        if (i.Nombres.ToLower()== nombre.ToLower() || i.Apellidos.ToLower() == nombre.ToLower()
                            || (i.Nombres + " " + i.Apellidos).ToLower() == nombre.ToLower())
                        {
                            
                            if (i.Fecha.ToString().Split('/')[2].Substring(0,4) == year)
                            {
                                filtrado.Add(i);
                            }
                        }
                    }
                    Console.WriteLine("Tipo: " + busqueda.GetType().Name + " Valor: " + busqueda.ToString() + " Filtro: 3");

                }
                else
                {
                    Console.WriteLine("Tipo: " + busqueda.GetType().Name + " Valor: " + busqueda.ToString() + " Filtro: 4");
                    //Empresion lamda para crear las condiciones de busquedas
                    filtrado = buscar.ToList();
                }
                //Pasamos la lista de consultas al dataGridView
                dtgPagos.DataSource = filtrado.ToList();
                dtgPagos.Columns[0].Visible = false;
                cargarDatosContadores(filtrado.ToList());
            }

        }

        private void cargarDatosContadores(List<PagosViewModel> listaPagos)
        {
            //filtrando datos a las cajas
            decimal monto = 0;
            decimal montoCancelado = 0;
            decimal montoPendiente = 0;
            decimal impuestos = 0;
            foreach (var i in listaPagos)
            {
                 monto += i.Monto;
                 montoCancelado += (decimal)i.Cancelado;
                 montoPendiente += (decimal)i.Pendiente;
                 impuestos += (decimal)i.Impuesto;
            }
            lblTotalPagoBase.Text = "$" + monto;
            lblTotalCancelado.Text = "$" + montoCancelado;
            lblTotalPendiente.Text = "$" + montoPendiente;
            lblTotalImpuesto.Text = "$" + impuestos;

        }

        private void FrmPagos_Load(object sender, EventArgs e)
        {
            Buscador(0);
            dtgPagos.Columns[0].Visible = false;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Buscador(0);
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

        private void cbBuscarConsumidor_TextChanged(object sender, EventArgs e)
        {
 
        }
        private void filtrarDeConsumidores(String busqueda)
        {
            using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {
                var dataConsumidores = (from a in db.Consumidores
                                        where (a.nombresConsumidor + " " + a.apellidosConsumidor).ToLower().Contains(busqueda.ToLower())
                                        select new
                                        {
                                            nombre = a.nombresConsumidor + " " + a.apellidosConsumidor
                                        }).ToList();
                

                if (dataConsumidores.Count > 0)
                {
                    cbBuscarConsumidor.ResetText();
                    cbBuscarConsumidor.DataSource = dataConsumidores;
                    cbBuscarConsumidor.DisplayMember = "nombre";
                    cbBuscarConsumidor.DroppedDown = true;
                    cbBuscarConsumidor.SelectedIndex = -1;
                }
                cbBuscarConsumidor.SelectionStart = busqueda.Length - 1;
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (txtFilter.Text.Trim() != "")
            {
                filtrarDeConsumidores(txtFilter.Text);
            }
        }

        private void btnAgregadoRapido_Click(object sender, EventArgs e)
        {
            new FrmGestionDePagosOptimizados().Show();
        }

        private void btnAgregadoRapido_MouseHover(object sender, EventArgs e)
        {
            btn.BotonAzulOscuro = btnAgregadoRapido;
            button.AzulOscuro(btn);
            btnAgregadoRapido.ForeColor = Color.White;
        }

        private void btnAgregadoRapido_MouseLeave(object sender, EventArgs e)
        {
            btnAgregadoRapido.BackColor = Color.White;
            btnAgregadoRapido.ForeColor = Color.Black;
        }

        private void btnAgregadoRapido_MouseMove(object sender, MouseEventArgs e)
        {
            btn.BotonAzulOscuro = btnAgregadoRapido;
            button.AzulOscuro(btn);
            btnAgregadoRapido.ForeColor = Color.White;
        }
    }
}
