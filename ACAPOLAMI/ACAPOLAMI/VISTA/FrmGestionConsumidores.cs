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
            if (txtNombres.Text.Equals("Introduzca los nombres"))
            {
                txtNombres.Text = "";
            }

        }

        private void txtNombres_Leave(object sender, EventArgs e)
        {
            if (txtNombres.Text.Equals(""))
            {
                txtNombres.Text = "Introduzca los nombres";
            }
        }

        private void txtDUI_Enter(object sender, EventArgs e)
        {
            if (txtDUI.Text.Equals("Introduzca el número de DUI"))
            {
                txtDUI.Text = "";
            }
        }

        private void txtDUI_Leave(object sender, EventArgs e)
        {
            if (txtDUI.Text.Equals(""))
            {
                txtDUI.Text = "Introduzca el número de DUI";
            }
        }

        private void txtApellidos_Enter(object sender, EventArgs e)
        {
            if (txtApellidos.Text.Equals("Introduzca los apellidos"))
            {
                txtApellidos.Text = "";
            }
        }

        private void txtApellidos_Leave(object sender, EventArgs e)
        {
            if (txtApellidos.Text.Equals(""))
            {
                txtApellidos.Text = "Introduzca los apellidos";
            }
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtTelefono.Text.Equals("0000-0000"))
            {
                txtTelefono.Text = "";
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.Text.Equals(""))
            {
                txtTelefono.Text = "0000-0000";
            }
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text.Equals("ejemplo@gmail.com"))
            {
                txtCorreo.Text = "";
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text.Equals(""))
            {
                txtCorreo.Text = "ejemplo@gmail.com";
            }
        }

        //metodo para limpiar las cajas de texto si se elije el radiobutton agregar
        private void Limpiar()
        {
                txtNombres.Text= "Introduzca los nombres";
                txtApellidos.Text = "Introduzca los apellidos";
                txtDUI.Text= "Introduzca el número de DUI";
                txtTelefono.Text= "0000-0000";
                txtCorreo.Text = "ejemplo@gmail.com";
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
            if (btnEjecutar.Text.Equals("Modificar registro")||btnEjecutar.Text.Equals("Eliminar registro"))
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
            if(ValidarCajasTexto() && btnEjecutar.Text.Equals("Agregar consumidor"))
            {
                //METODO PARA GUARDAR NUEVO CONSUMIDOR
                ClsDConsumidores clsconsumidor = new ClsDConsumidores();

                Consumidores consumidor = new Consumidores();

                if (cbComunidad.Text == "")
                {
                    consumidor.idComunidad_FK = null;
                }
                else
                {
                    consumidor.idComunidad_FK = Convert.ToInt32(idComunidadSeleccionado);
                }

                clsconsumidor.InsertarConsumidor(txtNombres.Text, txtApellidos.Text, txtDUI.Text, 
                    txtTelefono.Text, txtCorreo.Text, Convert.ToInt32(idComunidadSeleccionado));

                Limpiar();
            }
            else if (ValidarCajasTexto() && btnEjecutar.Text.Equals("Modificar registro"))
            {
                //METODO PARA MODIFICAR RESGISTRO
                try
                {
                    ClsDConsumidores clsDconsumidores = new ClsDConsumidores();

                    clsDconsumidores.ActualizarConsumidor(Convert.ToInt32(txtCodigo.Text), txtNombres.Text,
                                                         txtApellidos.Text, txtDUI.Text, txtTelefono.Text,
                                                         Convert.ToInt32(cbComunidad.SelectedValue), txtCorreo.Text);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                this.Close();
            }
            else if (ValidarCajasTexto() && btnEjecutar.Text.Equals("Eliminar registro"))
            {
                //METODO PARA ELIMINAR RESGISTRO
                try
                {
                    using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
                    {
                        ClsDConsumidores clsDconsumidor = new ClsDConsumidores();

                        clsDconsumidor.EliminarConsumidor(Convert.ToInt32(txtCodigo.Text));

                        this.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
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
    }
}
