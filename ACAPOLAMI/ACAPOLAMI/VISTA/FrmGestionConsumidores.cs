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
    public partial class FrmGestionConsumidores : Form
    {
        ClsDSucesos sucesos = new ClsDSucesos();
        public FrmGestionConsumidores()
        {
            InitializeComponent();
            ListarComunidades();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int posX = 0;
        int posY = 0;
        private void pnlEncabezado_MouseMove(object sender, MouseEventArgs e)
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

        private void txtNombres_Enter(object sender, EventArgs e)
        {
            if (txtNombres.Text.Equals("Primero Segundo"))
            {
                txtNombres.Text = "";
                txtNombres.ForeColor = Color.RoyalBlue;
            }

        }

        private void txtNombres_Leave(object sender, EventArgs e)
        {
            if (txtNombres.Text.Equals(""))
            {
                txtNombres.Text = "Primero Segundo";
                txtNombres.ForeColor = Color.Gray;
            }
        }

        private void txtDUI_Enter(object sender, EventArgs e)
        {
            if (txtDUI.Text.Equals("00000000-0"))
            {
                txtDUI.Text = "";
                txtDUI.ForeColor = Color.RoyalBlue;
            }
        }

        private void txtDUI_Leave(object sender, EventArgs e)
        {
            if (txtDUI.Text.Equals(""))
            {
                txtDUI.Text = "00000000-0";
                txtDUI.ForeColor = Color.Gray;
            }
        }

        private void txtApellidos_Enter(object sender, EventArgs e)
        {
            if (txtApellidos.Text.Equals("Primero Segundo"))
            {
                txtApellidos.Text = "";
                txtApellidos.ForeColor = Color.RoyalBlue;
            }
        }

        private void txtApellidos_Leave(object sender, EventArgs e)
        {
            if (txtApellidos.Text.Equals(""))
            {
                txtApellidos.Text = "Primero Segundo";
                txtApellidos.ForeColor = Color.Gray;
            }
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {

        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {

        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text.Equals("ejemplo@correo.com"))
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.RoyalBlue;
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text.Equals(""))
            {
                txtCorreo.Text = "ejemplo@correo.com";
                txtCorreo.ForeColor = Color.Gray;
            }
        }

        //metodo para limpiar las cajas de texto si se elije el radiobutton agregar
        private void Limpiar()
        {
                txtNombres.Text= "Introduzca los nombres";
                txtApellidos.Text = "Introduzca los apellidos";
                txtDUI.Text= "Introduzca el número de DUI";
                txtTelefono.Text= "0000-0000";
                txtCorreo.Text = "ejemplo@correo.com";
                ListarComunidades();
        }


        //variable que almacenará el id de la comunidad selecionada
        private string idComunidadSeleccionado = "";
        private void cbComunidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbComunidad.SelectedValue != null)
            {
                idComunidadSeleccionado = cbComunidad.SelectedValue.ToString();
            }
        }

        //metodo para cargar las comunidades al combo box
        private void ListarComunidades()
        {
            using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {
                var lista = db.Comunidades.ToList();

                if (lista.Count > 0)
                {
                    cbComunidad.DataSource = lista;
                    cbComunidad.DisplayMember = "nombreComunidad";
                    cbComunidad.ValueMember = "idComunidad";
                }
            }

        }

        public String comunidad = "";
        //metodo para mostrar cuando carga el form por primera vez, la comunidad en las cajas de texto mientras no
        //este seleccionado el radiobutton de agregar
        private void CargarComunidad()
        {
            if (btnEjecutar.Text.Equals("Modificar")||btnEjecutar.Text.Equals("Eliminar"))
            {
                cbComunidad.Text = comunidad;
            }

        }

        #region EVENTOS DE CAMBIO DE COLORES EN LOS BOTONES
        ClsButtonColor color = new ClsButtonColor();
        ButtonColor boton = new ButtonColor();
        private void btnEjecutar_MouseHover(object sender, EventArgs e)
        {
            //enviando el boton que cambiara el color de su fondo al tipo de color correspondiente
            boton.BotonAzulClaro = btnEjecutar;
            //aplicando el color al boton
            color.AzulClaro(boton);
        }

        private void btnEjecutar_MouseLeave(object sender, EventArgs e)
        {
            //enviando el boton que cambiara el color de su fondo al tipo de color correspondiente
            boton.BotonAzulOscuro = btnEjecutar;
            //aplicando el color al boton
            color.AzulOscuro(boton);
        }

        private void btnEjecutar_MouseMove(object sender, MouseEventArgs e)
        {
            //enviando el boton que cambiara el color de su fondo al tipo de color correspondiente
            boton.BotonAzulClaro = btnEjecutar;
            //aplicando el color al boton
            color.AzulClaro(boton);
        }

        private void btnCerrarGestionConsumidores_MouseHover(object sender, EventArgs e)
        {
            //enviando el boton que cambiara el color de su fondo al tipo de color correspondiente
            boton.BotonRojo = btnCerrarGestionConsumidores;
            //aplicando el color al boton
            color.Rojo(boton);
        }

        private void btnCerrarGestionConsumidores_MouseLeave(object sender, EventArgs e)
        {
            //enviando el boton que cambiara el color de su fondo al tipo de color correspondiente
            boton.BotonAzulOscuro = btnCerrarGestionConsumidores;
            //aplicando el color al boton
            color.AzulOscuro(boton);
        }

        private void btnCerrarGestionConsumidores_MouseMove(object sender, MouseEventArgs e)
        {
            //enviando el boton que cambiara el color de su fondo al tipo de color correspondiente
            boton.BotonRojo = btnCerrarGestionConsumidores;
            //aplicando el color al boton
            color.Rojo(boton);
        }

        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            //enviando el boton que cambiara el color de su fondo al tipo de color correspondiente
            boton.BotonAzulClaro = btnCancelar;
            //aplicando el color al boton
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
            //enviando el boton que cambiara el color de su fondo al tipo de color correspondiente
            boton.BotonAzulClaro = btnCancelar;
            //aplicando el color al boton
            color.AzulClaro(boton);
            btnCancelar.ForeColor = Color.White;
        }
        #endregion

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            BorrarMensajesError();
            if(ValidarCajasTexto() && btnEjecutar.Text.Equals("Agregar"))
            {
                //Metodo para guardar nuevo consumidor
                ClsDConsumidores clsconsumidor = new ClsDConsumidores();

                Consumidores consumidor = new Consumidores();

                if (cbComunidad.Text == "")
                {
                    consumidor.idComunidad_FK = null;
                }
                else
                {
                    try
                    {

                    consumidor.idComunidad_FK = Convert.ToInt32(idComunidadSeleccionado);
                    }
                    catch(Exception ex)
                    {
                        FrmDialogoError.Error("Seleccione la comunidad");
                    }
                }

                try
                {
                    clsconsumidor.InsertarConsumidor(txtNombres.Text, txtApellidos.Text, txtDUI.Text,
                    txtTelefono.Text, txtCorreo.Text, Convert.ToInt32(idComunidadSeleccionado));
                FrmNotificaciones notificacion = new FrmNotificaciones(sucesos.CargarDatosSucesos().tipoSuceso,
                            sucesos.CargarDatosSucesos().descripcion, FrmNotificaciones.TipoAlerta.Realizado);
                notificacion.Show();

                Limpiar();

                }

                catch (Exception ex)
                {
                    FrmDialogoError.Error("Ha ocurrido el siguiente error: " + ex.Message);
                }

            }

            else if (ValidarCajasTexto() && btnEjecutar.Text.Equals("Modificar"))
            {
                //Metodo actualizar consumidor
                try
                {
                    ClsDConsumidores clsDconsumidores = new ClsDConsumidores();

                    clsDconsumidores.ActualizarConsumidor(Convert.ToInt32(txtCodigo.Text), txtNombres.Text,
                                                         txtApellidos.Text, txtDUI.Text, txtTelefono.Text,
                                                         Convert.ToInt32(cbComunidad.SelectedValue.ToString()), txtCorreo.Text);

                    FrmNotificaciones notificacion = new FrmNotificaciones(sucesos.CargarDatosSucesos().tipoSuceso,
                            sucesos.CargarDatosSucesos().descripcion, FrmNotificaciones.TipoAlerta.Advertencia);
                    notificacion.Show();

                    Limpiar();
                }

                catch (Exception ex)
                {
                    FrmDialogoError.Error("Ha ocurrido el siguiente error: " + ex.Message);
                }

                this.Close();
            }
            else if (ValidarCajasTexto() && btnEjecutar.Text.Equals("Eliminar"))
            {
                //Metodo para eliminar consumidor
                try
                {
                    ClsDConsumidores clsDconsumidor = new ClsDConsumidores();

                    clsDconsumidor.EliminarConsumidor(Convert.ToInt32(txtCodigo.Text));

                    FrmNotificaciones notificacion = new FrmNotificaciones(sucesos.CargarDatosSucesos().tipoSuceso,
                        sucesos.CargarDatosSucesos().descripcion, FrmNotificaciones.TipoAlerta.Error);
                    notificacion.Show();

                    this.Dispose();
                }
                catch (Exception ex)
                {
                    FrmDialogoError.Error("Ha ocurrido el siguiente error: " + ex.Message);
                }

                this.Close();
            }

        }

        //metodo para validar las cajas de texto cuando están vacias y sosn datos obligatorios
        private Boolean ValidarCajasTexto()
        {
            Boolean permitir = true;

            if (txtNombres.Text.Equals("Introduzca los nombres"))
            {                     //colocamos el icono de error, se manda el nombre de la caja y un mensaje
                ControlValidacion.SetError(txtNombres, "Este campo es obligatorio");
                permitir = false;
            }
            if (txtApellidos.Text.Equals("Introduzca los apellidos"))
            {                     //colocamos el icono de error, se manda el nombre de la caja y un mensaje
                ControlValidacion.SetError(txtApellidos, "Este campo es obligatorio");
                permitir = false;
            }
            if (txtDUI.Text.Equals("Introduzca el número de DUI"))
            {                     //colocamos el icono de error, se manda el nombre de la caja y un mensaje
                ControlValidacion.SetError(txtDUI, "Este campo es obligatorio");
                permitir = false;
            }
           
            return permitir;
        }

        //metodo para eliminar cuando se hayan ingresado datos en los campos obligatorios
        private void BorrarMensajesError()
        {
            ControlValidacion.SetError(txtNombres, "");
            ControlValidacion.SetError(txtApellidos, "");
            ControlValidacion.SetError(txtDUI, "");
        }

        private void FrmGestionConsumidores_Load(object sender, EventArgs e)
        {
            CargarComunidad();
        }

        private void txtTelefono_Enter_1(object sender, EventArgs e)
        {
            txtDUI.Select(0, txtTelefono.Text.Length);
            txtTelefono.ForeColor = Color.RoyalBlue;
        }

        private void txtTelefono_Leave_1(object sender, EventArgs e)
        {
            if(txtTelefono.Text == "")
                txtTelefono.ForeColor = Color.Gray;
        }

        private void TxtDUI_Leave_1(object sender, EventArgs e)
        {
            if (txtDUI.Text == "")
                txtDUI.ForeColor = Color.Gray;
        }

        private void TxtDUI_Enter_1(object sender, EventArgs e)
        {
            txtDUI.Select(0, txtDUI.Text.Length);
            txtDUI.ForeColor = Color.RoyalBlue;
        }

        private void txtDUI_Click(object sender, EventArgs e)
        {
            txtDUI.Select(0, txtDUI.Text.Length);
        }

        private void txtTelefono_Click(object sender, EventArgs e)
        {
            txtDUI.Select(0, txtTelefono.Text.Length);
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 27)
            {
                e.Handled = true;
                btnCancelar.PerformClick();
            }
        }
    }
}
