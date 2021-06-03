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
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }
        #region EVENTOS DE CAMBIO DE COLOR DE BOTONES
        ButtonColor boton = new ButtonColor();
        ClsButtonColor color = new ClsButtonColor();
        private void btnReporteConsumidor_MouseHover(object sender, EventArgs e)
        {
            boton.BotonAzulClaro = btnReporteConsumidor;
            color.AzulClaro(boton);
            btnReporteConsumidor.ForeColor = Color.White;
        }

        private void btnReporteConsumidor_MouseLeave(object sender, EventArgs e)
        {
            btnReporteConsumidor.BackColor = Color.GhostWhite;
            btnReporteConsumidor.ForeColor = Color.Black;
        }

        private void btnReporteConsumidor_MouseMove(object sender, MouseEventArgs e)
        {
            boton.BotonAzulClaro = btnReporteConsumidor;
            color.AzulClaro(boton);
            btnReporteConsumidor.ForeColor = Color.White;
        }

        private void btnReportePagos_MouseHover(object sender, EventArgs e)
        {
            boton.BotonAzulClaro = btnReportePagos;
            color.AzulClaro(boton);
            btnReportePagos.ForeColor = Color.White;
        }

        private void btnReportePagos_MouseLeave(object sender, EventArgs e)
        {
            btnReportePagos.BackColor = Color.Linen;
            btnReportePagos.ForeColor = Color.Black;
        }

        private void btnReportePagos_MouseMove(object sender, MouseEventArgs e)
        {
            boton.BotonAzulClaro = btnReportePagos;
            color.AzulClaro(boton);
            btnReportePagos.ForeColor = Color.White;
        }

        private void btnReporteActividad_MouseHover(object sender, EventArgs e)
        {
            boton.BotonAzulClaro = btnReporteActividad;
            color.AzulClaro(boton);
            btnReporteActividad.ForeColor = Color.White;
        }

        private void btnReporteActividad_MouseLeave(object sender, EventArgs e)
        {
            btnReporteActividad.BackColor = Color.AliceBlue;
            btnReporteActividad.ForeColor = Color.Black;
        }

        private void btnReporteActividad_MouseMove(object sender, MouseEventArgs e)
        {
            boton.BotonAzulClaro = btnReporteActividad;
            color.AzulClaro(boton);
            btnReporteActividad.ForeColor = Color.White;
        }
        #endregion
    }
}
