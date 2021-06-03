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

namespace ACAPOLAMI.VISTA
{
    public partial class FrmAjustes : Form
    {
        public FrmAjustes()
        {
            InitializeComponent();
        }

        private void FrmAjustes_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ptbIconoAjustes_Click(object sender, EventArgs e)
        {

        }
        #region EVENTOS PLACEHOLDER DE LAS CAJAS DE TEXTO
        private void txtComunidad_Enter(object sender, EventArgs e)
        {
            if (txtComunidad.Text.Equals("@nombre comunidad"))
            {
                txtComunidad.Text = "";
            }
        }

        private void txtComunidad_Leave(object sender, EventArgs e)
        {
            if (txtComunidad.Text.Equals(""))
            {
                txtComunidad.Text = "@nombre comunidad";
            }
        }

        private void txtEstado_Enter(object sender, EventArgs e)
        {
            if (txtEstado.Text.Equals("@nombre estado"))
            {
                txtEstado.Text = "";
            }
        }

        private void txtEstado_Leave(object sender, EventArgs e)
        {
            if (txtEstado.Text.Equals(""))
            {
                txtEstado.Text = "@nombre estado";
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("ejemplo@gmail.com"))
            {
                txtUsuario.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals(""))
            {
                txtUsuario.Text = "ejemplo@gmail.com";
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text.Equals("@nueva"))
            {
                txtPass.Text = "";
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text.Equals(""))
            {
                txtPass.Text = "@nueva";
            }
        }

        private void txtPassAntigua_Enter(object sender, EventArgs e)
        {
            if (txtPassAntigua.Text.Equals("@antigua"))
            {
                txtPassAntigua.Text = "";
            }
        }

        private void txtPassAntigua_Leave(object sender, EventArgs e)
        {
            if (txtPassAntigua.Text.Equals(""))
            {
                txtPassAntigua.Text = "@antigua";
            }
        }

        private void txtPagoBase_Enter(object sender, EventArgs e)
        {
            if (txtPagoBase.Text.Equals("0.0000"))
            {
                txtPagoBase.Text = "";
            }
        }

        private void txtPagoBase_Leave(object sender, EventArgs e)
        {
            if (txtPagoBase.Text.Equals(""))
            {
                txtPagoBase.Text = "0.0000";
            }
        }
        #endregion

        #region METODOS PARA EL CONTROL DE VALIDACIONES

        //private Boolean ValidacionCajasTexto()
        //{
        //    Boolean permitir = true;
        //    if (txtComunidad.Text.Equals("@nombre comunidad"))
        //    {
        //        controlValidaciones.SetError(txtComunidad, "Este campo es obligatorio");
        //        permitir = false;
        //    }
        //    if (txtEstado.Text.Equals("@nombre estado"))
        //    {
        //        controlValidaciones.SetError(txtEstado, "Este campo es obligatorio");
        //        permitir = false;
        //    }
        //    if (txtUsuario.Text.Equals("ejemplo@gmail.com"))
        //    {
        //        controlValidaciones.SetError(txtUsuario, "Este campo es obligatorio");
        //        permitir = false;
        //    }
        //    if (txtPass.Text.Equals("@nueva"))
        //    {
        //        controlValidaciones.SetError(txtPass, "Este campo es obligatorio");
        //        permitir = false;
        //    }
        //    if (txtPassAntigua.Text.Equals("@antigua"))
        //    {
        //        controlValidaciones.SetError(txtPassAntigua, "Este campo es obligatorio");
        //        permitir = false;
        //    }
        //    if (txtPagoBase.Text.Equals("0.0000"))
        //    {
        //        controlValidaciones.SetError(txtPagoBase, "Este campo es obligatorio");
        //        permitir = false;
        //    }
        //    return permitir;
        //}

        //private void DesactivarValidacion()
        //{
        //    controlValidaciones.SetError(txtCodigo, "");
        //    controlValidaciones.SetError(txtNombres, "");
        //    controlValidaciones.SetError(txtApellidos, "");
        //    controlValidaciones.SetError(txtMontoBase, "");
        //    controlValidaciones.SetError(txtCancelado, "");
        //    controlValidaciones.SetError(txtImpuesto, "");
        //}

        #endregion

        private void btnGuardarComunidad_Click(object sender, EventArgs e)
        {
            if (txtComunidad.Text.Equals("@nombre comunidad"))
            {
                controlValidaciones.SetError(txtComunidad, "Este campo es obligatorio,\npara ejecutar esta acción");
            }
            else
            {
                controlValidaciones.SetError(txtComunidad, "");
            }
        }

        private void btnGuardarEstado_Click(object sender, EventArgs e)
        {
            if (txtEstado.Text.Equals("@nombre estado"))
            {
                controlValidaciones.SetError(txtEstado, "Este campo es obligatorio,\npara ejecutar esta acción");
            }
            else
            {
                controlValidaciones.SetError(txtEstado, "");
            }
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("ejemplo@gmail.com")
                || txtPassAntigua.Text.Equals("@antigua"))
            {
                controlValidaciones.SetError(txtUsuario, "Este campo es obligatorio,\npara ejecutar esta acción");
                controlValidaciones.SetError(txtPassAntigua, "Para modificar su usuario y/o contraseña,\ndebe ingresar su antigua contraseña");
            }
            else
            {
                controlValidaciones.SetError(txtUsuario, "");
                controlValidaciones.SetError(txtPassAntigua, "");
            }
        }

        private void btnEstablecerPagoBase_Click(object sender, EventArgs e)
        {
            if (txtPagoBase.Text.Equals("0.0000"))
            {
                controlValidaciones.SetError(txtPagoBase, "Este campo es obligatorio,\npara ejecutar esta acción");
            }
            else
            {
                controlValidaciones.SetError(txtPagoBase, "");
            }
        }
        #region EVENTOS DEL CAMBIO DE COLORES DE LOS BOTONES
        ButtonColor boton = new ButtonColor();
        ClsButtonColor color = new ClsButtonColor();
        private void btnGuardarComunidad_MouseHover(object sender, EventArgs e)
        {
            boton.BotonAzulClaro = btnGuardarComunidad;
            color.AzulClaro(boton);
        }

        private void btnGuardarComunidad_MouseLeave(object sender, EventArgs e)
        {
            boton.BotonAzulOscuro = btnGuardarComunidad;
            color.AzulOscuro(boton);;
        }

        private void btnGuardarComunidad_MouseMove(object sender, MouseEventArgs e)
        {
            boton.BotonAzulClaro = btnGuardarComunidad;
            color.AzulClaro(boton);
        }

        private void btnEliminarComunidad_MouseHover(object sender, EventArgs e)
        {
            boton.BotonAzulClaro = btnEliminarComunidad;
            color.AzulClaro(boton);
            btnEliminarComunidad.ForeColor = Color.White;
        }

        private void btnEliminarComunidad_MouseLeave(object sender, EventArgs e)
        {
            btnEliminarComunidad.BackColor = Color.White;
            btnEliminarComunidad.ForeColor = Color.Black;
        }

        private void btnEliminarComunidad_MouseMove(object sender, MouseEventArgs e)
        {
            boton.BotonAzulClaro = btnEliminarComunidad;
            color.AzulClaro(boton);
            btnEliminarComunidad.ForeColor = Color.White;
        }

        private void btnGuardarEstado_MouseHover(object sender, EventArgs e)
        {
            boton.BotonAzulClaro = btnGuardarEstado;
            color.AzulClaro(boton);
        }

        private void btnGuardarEstado_MouseLeave(object sender, EventArgs e)
        {
            boton.BotonAzulOscuro = btnGuardarEstado;
            color.AzulOscuro(boton);
        }

        private void btnGuardarEstado_MouseMove(object sender, MouseEventArgs e)
        {
            boton.BotonAzulClaro = btnGuardarEstado;
            color.AzulClaro(boton);
        }

        private void btnEliminarEstado_MouseHover(object sender, EventArgs e)
        {
            boton.BotonAzulClaro = btnEliminarEstado;
            color.AzulClaro(boton);
            btnEliminarEstado.ForeColor = Color.White;
        }

        private void btnEliminarEstado_MouseLeave(object sender, EventArgs e)
        {
            btnEliminarEstado.ForeColor = Color.Black;
            btnEliminarEstado.BackColor = Color.White;
        }

        private void btnEliminarEstado_MouseMove(object sender, MouseEventArgs e)
        {
            boton.BotonAzulClaro = btnEliminarEstado;
            color.AzulClaro(boton);
            btnEliminarEstado.ForeColor = Color.White;
        }

        private void btnGuardarUsuario_MouseHover(object sender, EventArgs e)
        {
            boton.BotonAzulClaro = btnGuardarUsuario;
            color.AzulClaro(boton);
        }

        private void btnGuardarUsuario_MouseLeave(object sender, EventArgs e)
        {
            boton.BotonAzulOscuro = btnGuardarUsuario;
            color.AzulOscuro(boton);
        }

        private void btnGuardarUsuario_MouseMove(object sender, MouseEventArgs e)
        {
            boton.BotonAzulClaro = btnGuardarUsuario;
            color.AzulClaro(boton);
        }

        private void btnEliminarUsuario_MouseHover(object sender, EventArgs e)
        {
            boton.BotonAzulClaro = btnEliminarUsuario;
            color.AzulClaro(boton);
            btnEliminarUsuario.ForeColor = Color.White;
        }

        private void btnEliminarUsuario_MouseLeave(object sender, EventArgs e)
        {
            btnEliminarUsuario.BackColor = Color.White;
            btnEliminarUsuario.ForeColor = Color.Black;
        }

        private void btnEliminarUsuario_MouseMove(object sender, MouseEventArgs e)
        {
            boton.BotonAzulClaro = btnEliminarUsuario;
            color.AzulClaro(boton);
            btnEliminarUsuario.ForeColor = Color.White;
        }

        private void btnEstablecerPagoBase_MouseHover(object sender, EventArgs e)
        {
            boton.BotonAzulClaro = btnEstablecerPagoBase;
            color.AzulClaro(boton);
        }

        private void btnEstablecerPagoBase_MouseLeave(object sender, EventArgs e)
        {
            boton.BotonAzulOscuro = btnEstablecerPagoBase;
            color.AzulOscuro(boton);
        }

        private void btnEstablecerPagoBase_MouseMove(object sender, MouseEventArgs e)
        {
            boton.BotonAzulClaro = btnEstablecerPagoBase;
            color.AzulClaro(boton);
        }
        #endregion
    }
}
