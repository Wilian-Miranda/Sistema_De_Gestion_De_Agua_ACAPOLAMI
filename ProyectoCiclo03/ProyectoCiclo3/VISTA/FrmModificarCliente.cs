﻿using ProyectoCiclo3.DAO;
using ProyectoCiclo3.MODELO;
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
    public partial class FrmModificarCliente : Form
    {
        public FrmModificarCliente()
        {
            InitializeComponent();
        }

        private string idComunidad = "";

        private void pnlContenedorAgregarCliente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsDConsumidores clsDconsumidores = new ClsDConsumidores();

                Consumidores consumidor = new Consumidores();

                consumidor.idConsumidor = Convert.ToInt32(txtIdCliente.Text);
                consumidor.nombresConsumidor = txtNombre.Text;
                consumidor.apellidosConsumidor = txtApellidos.Text;
                consumidor.numeroDocumento = txtDUI.Text;
                consumidor.telefono = txtTelefono.Text;
                consumidor.correo = txtEmail.Text;
                consumidor.idComunidad_FK = Convert.ToInt32(idComunidad);

                clsDconsumidores.ModificarCliente(consumidor);
                Limpieza();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void FrmModificarCliente_Load(object sender, EventArgs e)
        {
            ListarComunidades();
        }
        void Limpieza() {
            txtIdCliente.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtDUI.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            cbComunidad.ResetText();
        } 

        private void btnModificar_MouseHover(object sender, EventArgs e)
        {
            btnModificar.BackColor =Color.FromArgb(0, 64, 64);
        }

        private void btnModificar_MouseLeave(object sender, EventArgs e)
        {
            btnModificar.BackColor = Color.DarkCyan;
        }

        private void btnModificar_MouseMove(object sender, MouseEventArgs e)
        {
            btnModificar.BackColor = Color.FromArgb(0, 64, 64);
        }

        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.FromArgb(0, 64, 64);
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.DarkCyan;
        }

        private void btnCancelar_MouseMove(object sender, MouseEventArgs e)
        {
            btnCancelar.BackColor = Color.FromArgb(0, 64, 64);
        }


        private void cbComunidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbComunidad.SelectedValue != null)
            {
                idComunidad = cbComunidad.SelectedValue.ToString();
            }
        }

        //Metodo para cargar los datos al ComboBox
        public string comunidad="";
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

                    cbComunidad.Text = comunidad;

                }
            }
        
       
        

    }
        int posX = 0;
        int posY = 0;
        private void pnlCabeceraModificarCliente_MouseMove(object sender, MouseEventArgs e)
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

    }
}
