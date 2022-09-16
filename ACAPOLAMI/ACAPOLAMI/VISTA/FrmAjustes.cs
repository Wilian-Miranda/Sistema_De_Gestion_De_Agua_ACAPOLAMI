﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACAPOLAMI.DAO;
using ACAPOLAMI.DOMINIO;
using ACAPOLAMI.MODELO;
using ACAPOLAMI.NEGOCIO;

namespace ACAPOLAMI.VISTA
{
    public partial class FrmAjustes : Form
    {
        public string montoBase;
        public FrmAjustes()
        {
            InitializeComponent();
            mostrar();
            txtPagoBase.Text = Properties.Settings.Default["montoBase"].ToString();
        }

        void mostrar()
        {
            dtgvComunidades.Rows.Clear();
            ClsDComunidad comunidad = new ClsDComunidad();
            List<Comunidades> tbcomunidad = comunidad.ConsultarComunidades();
            foreach (var iteracion in tbcomunidad)
            {
                dtgvComunidades.Rows.Add(iteracion.idComunidad, iteracion.nombreComunidad);
            }

            dtgvEstadosPago.Rows.Clear();
            ClsDEstados estado = new ClsDEstados();
            List<Estados> tbEstado = estado.MostrarEstados();
            foreach (var iteracion in tbEstado)
            {
                dtgvEstadosPago.Rows.Add(iteracion.idEstado, iteracion.nombreEstado);
            }

            dtgvUsuarios.Rows.Clear();
            ClsDUsuarios clsDUsuarios = new ClsDUsuarios();
            List<Usuarios> tbuser = clsDUsuarios.CargarUsuario();
            foreach (var iteracion in tbuser)
            {
                dtgvUsuarios.Rows.Add(iteracion.idUsuarios, iteracion.nombre, iteracion.clave);
            }
        }

        private void FrmAjustes_Load(object sender, EventArgs e)
        {
            mostrar();
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

        //private void btnEliminarComunidad_MouseHover(object sender, EventArgs e)
        //{
        //    boton.BotonAzulClaro = btnEliminarComunidad;
        //    color.AzulClaro(boton);
        //    btnEliminarComunidad.ForeColor = Color.White;
        //}

        //private void btnEliminarComunidad_MouseLeave(object sender, EventArgs e)
        //{
        //    btnEliminarComunidad.BackColor = Color.White;
        //    btnEliminarComunidad.ForeColor = Color.Black;
        //}

        //private void btnEliminarComunidad_MouseMove(object sender, MouseEventArgs e)
        //{
        //    boton.BotonAzulClaro = btnEliminarComunidad;
        //    color.AzulClaro(boton);
        //    btnEliminarComunidad.ForeColor = Color.White;
        //}

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

        ClsDComunidad comunidad = new ClsDComunidad();
        Comunidades tb_comunidades = new Comunidades();
        private void btnGuardarComunidad_Click_1(object sender, EventArgs e)
        {
            if (txtComunidad.Text.Equals("@nombre comunidad"))
            {
                controlValidaciones.SetError(txtComunidad, "Este campo es obligatorio,\npara ejecutar esta acción");
            }
            else if (txtComunidad.Text != "")
            {
                comunidad.GuardarComunidades(txtComunidad.Text);
                FrmDialogoExito.Confirmar("Se ha ingresado la comunidad");
                mostrar();
            }
            else
            {
                controlValidaciones.SetError(txtComunidad, "");
            }
        }

        ClsDEstados clsDEstado = new ClsDEstados(); 
        private void btnGuardarEstado_Click_1(object sender, EventArgs e)
        {
            if (txtEstado.Text.Equals("@nombre estado"))
            {
                controlValidaciones.SetError(txtEstado, "Este campo es obligatorio,\npara ejecutar esta acción");
            }
            else if (txtEstado.Text != "")
            {
                Estados estado = new Estados();
                estado.nombreEstado = txtEstado.Text;

                clsDEstado.GuardarEstado(estado);
                FrmDialogoExito.Confirmar("El estado se ha insertado con exito");
                mostrar();
            }
            else
            {
                controlValidaciones.SetError(txtEstado, "");
            }
            
        }

        private void btnEliminarEstado_Click(object sender, EventArgs e)
        {
            string idEstado = dtgvEstadosPago.CurrentRow.Cells[0].Value.ToString();
            clsDEstado.EliminarEstado(Convert.ToInt32(idEstado));

            mostrar();
        }

        ClsDUsuarios usuarios = new ClsDUsuarios();
        private void btnGuardarUsuario_Click_1(object sender, EventArgs e)
        {
            Usuarios user = new Usuarios();

            string name = txtUsuario.Text;
            string oldPass = txtPassAntigua.Text;
            string newPass = txtPass.Text;

            if (txtUsuario.Text.Equals("ejemplo@gmail..com")
                || txtPassAntigua.Text.Equals("@antigua"))
            {
                controlValidaciones.SetError(txtUsuario, "Este campo es obligatorio,\npara ejecutar esta acción");
                controlValidaciones.SetError(txtPassAntigua, "Para modificar su usuario y/o contraseña,\ndebe ingresar su antigua contraseña");
            }
            else if(!txtPassAntigua.Text.Equals("@antigua") || !txtPassAntigua.Text.Equals(""))
            {
                controlValidaciones.SetError(txtUsuario, "");
                controlValidaciones.SetError(txtPassAntigua, "");

                if (txtPass.Text.Equals("@nueva"))
                {
                    user.idUsuarios = Convert.ToInt32(dtgvUsuarios.CurrentRow.Cells[0].Value);
                    user.nombre = name;
                    user.clave = oldPass;

                    usuarios.ActualizarUsuario(user);
                    mostrar();
                }
                else
                {
                        user.idUsuarios = Convert.ToInt32(dtgvUsuarios.CurrentRow.Cells[0].Value);
                        user.nombre = name;
                        user.clave = oldPass;

                        usuarios.CambiarPass(user, newPass);
                        mostrar();
                    
                }
            }
            mostrar();
        }

        private void btnEstablecerPagoBase_Click_1(object sender, EventArgs e)
        {
            if (txtPagoBase.Text.Equals("0.0000"))
            {
                controlValidaciones.SetError(txtPagoBase, "Este campo es obligatorio,\npara ejecutar esta acción");
            }
            else
            {
                controlValidaciones.SetError(txtPagoBase, "");
            }

            if(txtPagoBase.Text != "0.0000")
            {
                //FrmPrincipal.pagoBase = txtPagoBase.Text;
                //guardando confuguracion en el sitema
                Properties.Settings.Default["montoBase"] = Convert.ToDecimal(txtPagoBase.Text);
                Properties.Settings.Default.Save();
                FrmDialogoExito.Confirmar("Se ha modificado el pago base");
            }
        }

        private void txtComunidad_Enter_1(object sender, EventArgs e)
        {
            if (txtComunidad.Text.Contains("@nombre comunidad"))
            {
                txtComunidad.Text = "";
                txtComunidad.ForeColor = Color.RoyalBlue;
            }
        }

        private void txtComunidad_Leave_1(object sender, EventArgs e)
        {
            if (txtComunidad.Text == "")
            {
                txtComunidad.Text = "@nombre comunidad";
                txtComunidad.ForeColor = Color.Gray;
            }
        }

        private void txtEstado_Enter_1(object sender, EventArgs e)
        {
            if (txtEstado.Text.Contains("@nombre estado"))
            {
                txtEstado.Text = "";
                txtEstado.ForeColor = Color.RoyalBlue;
            }
        }

        private void txtEstado_Leave_1(object sender, EventArgs e)
        {
            if (txtEstado.Text == "")
            {
                txtEstado.Text = "@nombre estado";
                txtEstado.ForeColor = Color.Gray;
            }
        }

        private void txtUsuario_Enter_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Contains("ejemplo@correo.com"))
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.RoyalBlue;
            }
        }

        private void txtUsuario_Leave_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "ejemplo@correo.com";
                txtUsuario.ForeColor = Color.Gray;
            }
        }

        private void txtPass_Enter_1(object sender, EventArgs e)
        {
            if (txtPass.Text.Contains("@nueva"))
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.RoyalBlue;
            }
        }

        private void txtPass_Leave_1(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "@nueva";
                txtPass.ForeColor = Color.Gray;
            }
        }

        private void txtPassAntigua_Enter_1(object sender, EventArgs e)
        {
            if (txtPassAntigua.Text.Contains("@antigua"))
            {
                txtPassAntigua.Text = "";
                txtPassAntigua.ForeColor = Color.RoyalBlue;
            }
        }

        private void txtPassAntigua_Leave_1(object sender, EventArgs e)
        {
            if (txtPassAntigua.Text == "")
            {
                txtPassAntigua.Text = "@antigua";
                txtPassAntigua.ForeColor = Color.Gray;
            }
        }

        private void txtPagoBase_Enter_1(object sender, EventArgs e)
        {
            if (txtPagoBase.Text.Contains("0.0000"))
            {
                txtPagoBase.Text = "";
                txtPagoBase.ForeColor = Color.RoyalBlue;
            }
        }

        private void txtPagoBase_Leave_1(object sender, EventArgs e)
        {
            if (txtPagoBase.Text == "")
            {
                txtPagoBase.Text = "0.0000";
                txtPagoBase.ForeColor = Color.Gray;
            }
        }

        private void txtPagoBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
            if (e.KeyChar == 13 && txtUsuario.Text != "")
            {
                e.Handled = true;
                btnEstablecerPagoBase.PerformClick();
            }
        }

        private void SoloNumeros(KeyPressEventArgs k)
        {
            if (char.IsDigit(k.KeyChar))
            {
                k.Handled = false;
            }

            else if (char.IsSeparator(k.KeyChar))
            {
                k.Handled = false;
            }

            else if (char.IsControl(k.KeyChar))
            {
                k.Handled = false;
            }

            else if (k.KeyChar.ToString().Equals("."))
            {
                k.Handled = false;
            }

            else
                k.Handled = true;
        }

        private void dtgvComunidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtComunidad.Text = dtgvComunidades.CurrentRow.Cells[1].Value.ToString();
        }

        private void dtgvEstadosPago_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombreEstado = dtgvEstadosPago.CurrentRow.Cells[1].Value.ToString();
            txtEstado.Text = nombreEstado;
        }

        private void dtgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombre = dtgvUsuarios.CurrentRow.Cells[1].Value.ToString();
            string clave = dtgvUsuarios.CurrentRow.Cells[2].Value.ToString();

            txtUsuario.Text = nombre;
            txtPassAntigua.Text = clave;
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
