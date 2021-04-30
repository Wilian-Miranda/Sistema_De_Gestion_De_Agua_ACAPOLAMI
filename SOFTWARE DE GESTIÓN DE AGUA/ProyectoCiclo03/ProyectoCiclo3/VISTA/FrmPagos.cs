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
    public partial class FrmPagos : Form
    {
        public FrmPagos()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegistrarPago_MouseHover(object sender, EventArgs e)
        {
            btnRegistrarPago.BackColor = Color.Blue;
            btnRegistrarPago.ForeColor = Color.White;
        }

        private void btnRegistrarPago_MouseLeave(object sender, EventArgs e)
        {
            btnRegistrarPago.BackColor = Color.WhiteSmoke;
            btnRegistrarPago.ForeColor = Color.Black;
        }

        private void btnRegistrarPago_MouseUp(object sender, MouseEventArgs e)
        {
            btnRegistrarPago.BackColor = Color.Blue;
            btnRegistrarPago.ForeColor = Color.White;
        }

        private void btnRegistrarPago_MouseMove(object sender, MouseEventArgs e)
        {
            btnRegistrarPago.BackColor = Color.Blue;
            btnRegistrarPago.ForeColor = Color.White;
        }

        private void btnModificarPago_MouseHover(object sender, EventArgs e)
        {
            btnModificarPago.BackColor = Color.Blue;
            btnModificarPago.ForeColor = Color.White;
        }

        private void btnModificarPago_MouseMove(object sender, MouseEventArgs e)
        {
            btnModificarPago.BackColor = Color.Blue;
            btnModificarPago.ForeColor = Color.White;
        }

        private void btnModificarPago_MouseUp(object sender, MouseEventArgs e)
        {
            btnModificarPago.BackColor = Color.Blue;
            btnModificarPago.ForeColor = Color.White;
        }

        private void btnModificarPago_MouseLeave(object sender, EventArgs e)
        {
            btnModificarPago.BackColor = Color.WhiteSmoke;
            btnModificarPago.ForeColor = Color.Black;
        }

        private void btnEliminarPago_MouseHover(object sender, EventArgs e)
        {
            btnEliminarPago.BackColor = Color.Crimson;
            btnEliminarPago.ForeColor = Color.White;
        }

        private void btnEliminarPago_MouseLeave(object sender, EventArgs e)
        {
            btnEliminarPago.BackColor = Color.WhiteSmoke;
            btnEliminarPago.ForeColor = Color.Black;
        }

        private void btnEliminarPago_MouseMove(object sender, MouseEventArgs e)
        {
            btnEliminarPago.BackColor = Color.Crimson;
            btnEliminarPago.ForeColor = Color.White;
        }

        private void btnEliminarPago_MouseUp(object sender, MouseEventArgs e)
        {
            btnEliminarPago.BackColor = Color.Crimson;
            btnEliminarPago.ForeColor = Color.White;
        }

        private void btnBuscarConsumidor_MouseHover(object sender, EventArgs e)
        {
            btnBuscarConsumidor.BackColor = Color.Blue;
            btnBuscarConsumidor.ForeColor = Color.White;
        }

        private void btnBuscarConsumidor_MouseMove(object sender, MouseEventArgs e)
        {
            btnBuscarConsumidor.BackColor = Color.Blue;
            btnBuscarConsumidor.ForeColor = Color.White;
        }

        private void btnBuscarConsumidor_MouseUp(object sender, MouseEventArgs e)
        {
            btnBuscarConsumidor.BackColor = Color.Blue;
            btnBuscarConsumidor.ForeColor = Color.White;
        }

        private void btnBuscarConsumidor_MouseLeave(object sender, EventArgs e)
        {
            btnBuscarConsumidor.BackColor = Color.WhiteSmoke;
            btnBuscarConsumidor.ForeColor = Color.Black;
        }

        private void btnModificarPago_Click(object sender, EventArgs e)
        {

        }
    }
}
