using ACAPOLAMI.MODELO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACAPOLAMI.DOMINIO;
using ACAPOLAMI.NEGOCIO;
using ACAPOLAMI.DAO;

namespace ACAPOLAMI.VISTA
{
    public partial class FrmGestionPagos : Form
    {
        ClsDSucesos sucesos = new ClsDSucesos();
        public string Id;
        public FrmGestionPagos()
        {
            InitializeComponent();
            CargarEstados();
        }

        private void FrmGestioPagos_Load(object sender, EventArgs e)
        {
            DatosCBseleccionados();
        }

        public String estado;
        public String nombreNonsumidor;
        private void DatosCBseleccionados()
        {
           cbEstado.Text = estado;
           cbConsumidor.Text = nombreNonsumidor;
            using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {
                var cargarDatos = (from a in db.sp_MostrarConsumidores()
                                   where (a.Nombres + " " + a.Apellidos) == nombreNonsumidor
                                   select a).ToList();
                foreach (var i in cargarDatos)
                {
                    txtCodigo.Text = i.Id.ToString();
                    txtNombres.Text = i.Nombres;
                    txtApellidos.Text = i.Apellidos;
                }
            }
        }

        private void btnBuscarConsumidor_Click(object sender, EventArgs e)
        {
            if (!cbConsumidor.Text.Equals(""))
            {
                using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
                {
                    var consumidores = (from a in db.sp_MostrarConsumidores()
                                        where a.Nombres.Contains(cbConsumidor.Text)
                                        || a.Apellidos.Contains(cbConsumidor.Text)
                                        select new
                                        {
                                            a.Id,
                                            nombres = a.Nombres + " " + a.Apellidos,
                                        }).ToList();

                    cbConsumidor.DataSource = consumidores.ToList();
                    cbConsumidor.DisplayMember = "nombres";
                    cbConsumidor.ValueMember = "Id";
                }
            }
        }
        private void ConsumidorCBSeleccionado()
        {
            if (cbConsumidor.SelectedIndex != -1)
            {
                String id= cbConsumidor.SelectedValue.ToString();

                using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
                {
                    var agregarDatos = (from a in db.sp_MostrarConsumidores()
                                        where a.Id.ToString() == id
                                        select new
                                        {
                                            a.Id,
                                            a.Nombres,
                                            a.Apellidos
                                        }).ToList();
                    foreach (var i in agregarDatos)
                    {
                        txtCodigo.Text = i.Id.ToString();
                        txtNombres.Text = i.Nombres;
                        txtApellidos.Text = i.Apellidos;
                    }

                    var deuda = (from a in db.Pagos
                                 where a.idConsumidor_FK.ToString() == id
                                 select a.montoTotal).ToList();
                    txtTotal.Text = deuda.Sum().ToString();
                }
            }
        }

        private void txtImpuesto_Enter(object sender, EventArgs e)
        {
            if (txtImpuesto.Text.Equals("Impuesto/mora/multa a cobrar"))
            {
                txtImpuesto.Text = "";
            }
        }

        private void txtImpuesto_Leave(object sender, EventArgs e)
        {
            if (txtImpuesto.Text.Equals(""))
            {
                txtImpuesto.Text = "Impuesto/mora/multa a cobrar";
            }
        }

        private void txtMontoBase_Enter(object sender, EventArgs e)
        {
            if (txtMontoBase.Text.Equals("Pago base por mes a pagar"))
            {
                txtMontoBase.Text = "";
            }
        }

        private void txtMontoBase_Leave(object sender, EventArgs e)
        {
            if (txtMontoBase.Text.Equals(""))
            {
                txtMontoBase.Text = "Pago base por mes a pagar";
            }
        }

        private void txtCancelado_Enter(object sender, EventArgs e)
        {
            if (txtCancelado.Text.Equals("Pago recibido"))
            {
                txtCancelado.Text = "";
            }
        }

        private void txtCancelado_Leave(object sender, EventArgs e)
        {
            if (txtCancelado.Text.Equals(""))
            {
                txtCancelado.Text = "Pago recibido";
            }
        }

        private Boolean ValidacionCajasTexto()
        {
            Boolean permitir = true;
            if (txtMontoBase.Text.Equals("Pago base por mes a pagar"))
            {
                ControlValidacion.SetError(txtMontoBase, "Este campo es obligatorio");
                permitir = false;
            }
            if (txtCancelado.Text.Equals("Pago recibido"))
            {
                ControlValidacion.SetError(txtCancelado, "Este campo es obligatorio");
                permitir = false;
            }
            if (txtImpuesto.Text.Equals("Impuesto/mora/multa a cobrar"))
            {
                ControlValidacion.SetError(txtImpuesto, "Este campo es obligatorio");
                permitir = false;
            }
            if (txtCodigo.Text.Equals("Codigo"))
            {
                ControlValidacion.SetError(txtCodigo, "Este campo es obligatorio");
                permitir = false;
            }
            if (txtNombres.Text.Equals("Introduzca los nombres"))
            {
                ControlValidacion.SetError(txtNombres, "Este campo es obligatorio");
                permitir = false;
            }
            if (txtApellidos.Text.Equals("Introduzca los apellidos"))
            {
                ControlValidacion.SetError(txtApellidos, "Este campo es obligatorio");
                permitir = false;
            }
            return permitir;
        }

        private void DesactivarValidacion()
        {
            ControlValidacion.SetError(txtCodigo, "");
            ControlValidacion.SetError(txtNombres, "");
            ControlValidacion.SetError(txtApellidos, "");
            ControlValidacion.SetError(txtMontoBase, "");
            ControlValidacion.SetError(txtCancelado, "");
            ControlValidacion.SetError(txtImpuesto, "");
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            DesactivarValidacion();
            if (ValidacionCajasTexto()&&btnEjecutar.Text.Equals("Insertar"))
            {
                //CODIGO DE AGREGAR PAGO AQUI
                ClsDPagos pago = new ClsDPagos();

                pago.AgregarPago(Convert.ToDecimal(txtMontoBase.Text), Convert.ToDecimal(txtCancelado.Text), 
                    Convert.ToDecimal(txtPendiente.Text), Convert.ToDecimal(txtImpuesto.Text), Convert.ToDecimal(txtTotal.Text),
                    Convert.ToDateTime(dtpFechaPago.Text), Convert.ToInt32(cbEstado.SelectedValue.ToString()), 
                    Convert.ToInt32(cbConsumidor.SelectedValue.ToString()));

                FrmNotificaciones notificacion = new FrmNotificaciones(sucesos.CargarDatosSucesos().tipoSuceso,
                            sucesos.CargarDatosSucesos().descripcion, FrmNotificaciones.TipoAlerta.Realizado);
                notificacion.Show();

                Limpiar();

                MessageBox.Show("Se inserto correctamente");
                btnLimpiar.PerformClick();
            }
            else if (ValidacionCajasTexto()&&btnEjecutar.Text.Equals("Actualizar"))
            {
                //CODIGO DE MOFIFICAR PAGO AQUI
                ClsDPagos pago = new ClsDPagos();

                pago.Modificarpago(Convert.ToInt32(Id),Convert.ToDecimal(txtMontoBase.Text), Convert.ToDecimal(txtCancelado.Text),
                    Convert.ToDecimal(txtPendiente.Text), Convert.ToDecimal(txtImpuesto.Text), Convert.ToDecimal(txtTotal.Text),
                    Convert.ToDateTime(dtpFechaPago.Text), Convert.ToInt32(cbEstado.SelectedValue.ToString()),
                    Convert.ToInt32(txtCodigo.Text));

                FrmNotificaciones notificacion = new FrmNotificaciones(sucesos.CargarDatosSucesos().tipoSuceso,
                            sucesos.CargarDatosSucesos().descripcion, FrmNotificaciones.TipoAlerta.Realizado);
                notificacion.Show();

                Limpiar();


                MessageBox.Show("Se actualizo correctamente");
                this.Close();
            }
            else if (ValidacionCajasTexto() && btnEjecutar.Text.Equals("Eliminar"))
            {
                //CODIGO DE ELIMINAR PAGO AQUI
                ClsDPagos pago = new ClsDPagos();

                pago.EliminarPago(Convert.ToInt32(txtCodigo.Text));

                FrmNotificaciones notificacion = new FrmNotificaciones(sucesos.CargarDatosSucesos().tipoSuceso,
                        sucesos.CargarDatosSucesos().descripcion, FrmNotificaciones.TipoAlerta.Realizado);
                notificacion.Show();

                MessageBox.Show("Se elimino correctamente");

                this.Dispose();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrarGestionConsumidores_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region CONTROL DE EVENTOS DE CAMBIO DE COLOR DE LOS BOTONES
        ButtonColor boton = new ButtonColor();
        ClsButtonColor color = new ClsButtonColor();
        private void btnCerrarGestionConsumidores_MouseHover(object sender, EventArgs e)
        {
            boton.BotonRojo = btnCerrarGestionConsumidores;
            color.Rojo(boton);
        }

        private void btnCerrarGestionConsumidores_MouseLeave(object sender, EventArgs e)
        {
            boton.BotonAzulOscuro = btnCerrarGestionConsumidores;
            color.AzulOscuro(boton);
        }

        private void btnCerrarGestionConsumidores_MouseMove(object sender, MouseEventArgs e)
        {
            boton.BotonRojo = btnCerrarGestionConsumidores;
            color.Rojo(boton);
        }

        private void btnLimpiar_MouseHover(object sender, EventArgs e)
        {
            boton.BotonAzulClaro = btnLimpiar;
            color.AzulClaro(boton);
            btnLimpiar.ForeColor = Color.White;
        }

        private void btnLimpiar_MouseLeave(object sender, EventArgs e)
        {
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.ForeColor = Color.Black;
        }

        private void btnLimpiar_MouseMove(object sender, MouseEventArgs e)
        {
            boton.BotonAzulClaro = btnLimpiar;
            color.AzulClaro(boton);
            btnLimpiar.ForeColor = Color.White;
        }

        private void btnEjecutar_MouseHover(object sender, EventArgs e)
        {
            boton.BotonAzulClaro = btnEjecutar;
            color.AzulClaro(boton);
        }

        private void btnEjecutar_MouseLeave(object sender, EventArgs e)
        {
            boton.BotonAzulOscuro = btnEjecutar;
            color.AzulOscuro(boton);
        }

        private void btnEjecutar_MouseMove(object sender, MouseEventArgs e)
        {
            boton.BotonAzulClaro = btnEjecutar;
            color.AzulClaro(boton);
        }

        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            boton.BotonAzulClaro = btnCancelar;
            color.AzulClaro(boton);
            btnCancelar.ForeColor = Color.White;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.White;
            btnCancelar.ForeColor = Color.Black;
        }

        private void btnCancelar_MouseMove(object sender, MouseEventArgs e)
        {
            boton.BotonAzulClaro = btnCancelar;
            color.AzulClaro(boton);
            btnCancelar.ForeColor = Color.White;
        }

        private void btnBuscarConsumidor_MouseHover(object sender, EventArgs e)
        {
            boton.BotonAzulClaro = btnBuscarConsumidor;
            color.AzulClaro(boton);

        }

        private void btnBuscarConsumidor_MouseLeave(object sender, EventArgs e)
        {
            btnBuscarConsumidor.BackColor = Color.White;
            btnBuscarConsumidor.ForeColor = Color.Black;
        }

        private void btnBuscarConsumidor_MouseMove(object sender, MouseEventArgs e)
        {
            boton.BotonAzulClaro = btnBuscarConsumidor;
            color.AzulClaro(boton);
        }
        #endregion

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtCodigo.Text = "Codigo";
            txtNombres.Text = "Introduzca los nombres";
            txtApellidos.Text = "Introduzca los apellidos";
            txtMontoBase.Text = "Pago base por mes a pagar";
            txtCancelado.Text = "Pago recibido";
            txtImpuesto.Text = "Impuesto/mora/multa a cobrar";
            txtTotal.Text = "Deuda global acumulada";
        }

        //metodo para cargar el los estados
        private void CargarEstados()
        {
            using(ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {
                var estados = (from a in db.Estados
                               select a).ToList();

                cbEstado.DataSource = estados.ToList();
                cbEstado.DisplayMember = "nombreEstado";
                cbEstado.ValueMember = "idEstado";

            }
        }
        //Evento para mover el formulario
        int posX = 0;
        int posY = 0;
        private void pnlEncabezado_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button!=MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left += e.X - posX;
                Top += e.Y - posY;
            }
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left += e.X - posX;
                Top += e.Y - posY;
            }
        }

        private void cbConsumidor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConsumidorCBSeleccionado();
        }
    }
}
