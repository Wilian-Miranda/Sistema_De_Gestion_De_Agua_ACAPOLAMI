﻿using System;
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
            this.Dispose();
        }

        private void FrmModificarCliente_Load(object sender, EventArgs e)
        {
          
        }

        int posX = 0;
        int posY = 0;
        private void pnlCabeceraModificarCliente_MouseUp(object sender, MouseEventArgs e)
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
    }
}