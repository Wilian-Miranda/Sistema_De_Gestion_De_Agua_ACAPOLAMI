using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACAPOLAMI.DAO;
using ACAPOLAMI.MODELO;
using ACAPOLAMI.NEGOCIO;
using ACAPOLAMI.DOMINIO;
using System.Collections;

namespace ACAPOLAMI.VISTA
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
            cargarCBPagosYears();
            GraficoPagosEnMesesPorYears();
            cargarCBYears();

        }
        ButtonColor boton = new ButtonColor();
        ClsButtonColor color = new ClsButtonColor();
        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            TotalIngresos();
            GraficoComunidadesPorCliente();
            //cargarCBYears();
            cargarCBMesInicial();
            //CargarCBConsumidores();
            //GraficoPagosEnMesesPorYears();
            //cargarCBPagosYears();
            CargarUltimosClientes();
            CargarUltimosPagos();
            cbPagosYearGrafico.SelectedIndex = 0;
            btnFiltro.PerformClick();
        }

        private void TotalIngresos()
        {
            using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {
                var totalPagar = (from a in db.Pagos
                             select a.monto
                             ).ToList();
                lblTotaPagar.Text = "$"+totalPagar.Sum().ToString();

                var totalCancelado = (from a in db.Pagos
                                 select a.montoCancelado).ToList();
                lblTotalPagado.Text = "$"+ totalCancelado.Sum().ToString();

                var totalPendiente = (from a in db.Pagos
                                      select a.montoPendiente).ToList();
                lblTotalPendiente.Text = "$" + totalPendiente.Sum().ToString();

                var totalClientes = (from a in db.Consumidores
                                      select a.idConsumidor).ToList();
                lblTotalConsumidores.Text = totalClientes.Count.ToString();

                var totalCom = (from a in db.Comunidades
                                     select a.idComunidad).ToList();
                lblTotalComunidades.Text = totalCom.Count.ToString();

            }
        }
        private int MesesToEntero(int mes)
        {
            if (cbMes.Text.Equals("Enero"))
            {
                mes = 01;
            }
            else if (cbMes.Text.Equals("Febrero"))
            {
                mes = 02;
            }
            else if (cbMes.Text.Equals("Marzo"))
            {
                mes = 03;
            }
            else if (cbMes.Text.Equals("Abril"))
            {
                mes = 04;
            }
            else if (cbMes.Text.Equals("Mayo"))
            {
                mes = 05;
            }
            else if (cbMes.Text.Equals("Junio"))
            {
                mes = 06;
            }
            else if (cbMes.Text.Equals("Julio"))
            {
                mes = 07;
            }
            else if (cbMes.Text.Equals("Agosto"))
            {
                mes = 08;
            }
            else if (cbMes.Text.Equals("Septiembre"))
            {
                mes = 09;
            }
            else if (cbMes.Text.Equals("Octubre"))
            {
                mes = 10;
            }
            else if (cbMes.Text.Equals("Noviembre"))
            {
                mes = 11;
            }
            else
            {
                mes = 12;
            }
            return mes;
        }
        private void TotalIngresosFiltrados()
        {
            try
            {
                int mes = 0;
                long year = 0;

                if (cbYear.Text != "")
                {
                    year = Convert.ToInt64(cbYear.Text);
                }
                mes = MesesToEntero(mes);

                if (cbYear.Text != "" && cbMes.Text.Equals(""))
                {
                    using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
                    {
                        var totalPagar = (from a in db.Pagos
                                          where a.fechaPago.Year == year
                                          select a.monto).ToList();
                        lblTotaPagar.Text = "$" + totalPagar.Sum().ToString();

                        var totalCancelado = (from a in db.Pagos
                                              where a.fechaPago.Year == year
                                              select a.montoCancelado).ToList();
                        lblTotalPagado.Text = "$" + totalCancelado.Sum().ToString();

                        var totalPendiente = (from a in db.Pagos
                                              where a.fechaPago.Year == year
                                              select a.montoPendiente).ToList();
                        lblTotalPendiente.Text = "$" + totalPendiente.Sum().ToString();

                        var totalImpuesto = (from a in db.Pagos
                                              where a.fechaPago.Year == year
                                              select a.impuesto).ToList();
                        lblTotalImpuesto.Text = "$" + totalImpuesto.Sum().ToString();

                    }

                }
                else if (cbYear.Text != "" && cbMes.Text != "")
                {
                    using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
                    {
                        var totalPagar = (from a in db.Pagos
                                          where a.fechaPago.Year == year && a.fechaPago.Month == mes
                                          select a.monto).ToList();
                        lblTotaPagar.Text = "$" + totalPagar.Sum().ToString();

                        var totalCancelado = (from a in db.Pagos
                                              where a.fechaPago.Year == year && a.fechaPago.Month == mes
                                              select a.montoCancelado).ToList();
                        lblTotalPagado.Text = "$" + totalCancelado.Sum().ToString();

                        var totalPendiente = (from a in db.Pagos
                                              where a.fechaPago.Year == year && a.fechaPago.Month == mes
                                              select a.montoPendiente).ToList();
                        lblTotalPendiente.Text = "$" + totalPendiente.Sum().ToString();

                        var totalImpuesto = (from a in db.Pagos
                                             where a.fechaPago.Year == year && a.fechaPago.Month == mes
                                             select a.impuesto).ToList();
                        lblTotalImpuesto.Text = "$" + totalImpuesto.Sum().ToString();

                    }
                }
                else
                {
                    MessageBox.Show("Datos ingresados no son válidos para al realizar el filtro de datos");
                }
            }catch(Exception ex)
            {

            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GraficoComunidadesPorCliente()
        {
            using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {
                var comunidad = (from a in db.sp_ConsumidoresPorComunidad()
                                select a.Comunidad).ToList();
                var consumidorPorComunidad = (from a in db.sp_ConsumidoresPorComunidad()
                                 select a.Total_Consumidores).ToList();
                graficoComunidadXconsumidor.Series[0].Points.DataBindXY(comunidad, consumidorPorComunidad);
            }
           
        }
        private void GraficoPagosEnMesesPorYears()
        {
            using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {
                String mesFiltro = DateTime.Now.Year.ToString();
                var meses = (from a in db.sp_obtenerMontoCanceladoMeses(mesFiltro)
                                 select a.Mes).ToList();
                var total = (from a in db.sp_obtenerMontoCanceladoMeses(mesFiltro)
                             select a.Total_cancelado).ToList();
                graficoPagosMesesPorYear.Series[0].Points.DataBindXY(meses, total);
            }

        }

        private void cargarCBYears()
        {
            using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {
                var years = (from a in db.Pagos
                             select a.fechaPago.Year).ToList();

                cbYear.DataSource = years.Distinct().ToList();
                cbYear.DisplayMember = "fechaPago";
                if (cbYear.Items.Count > 0)
                {
                    cbYear.SelectedIndex = -1;
                }


            }
        }
        private void cargarCBPagosYears()
        {
            using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {
                var years = (from a in db.Pagos
                             select a.fechaPago.Year).ToList();

                cbPagosYearGrafico.DataSource = years.Distinct().ToList();
                cbPagosYearGrafico.DisplayMember = "fechaPago";
                if (cbPagosYearGrafico.Items.Count > 0)
                {
                    cbPagosYearGrafico.SelectedIndex = -1;
                }
            }
        }

        private void cargarCBMesInicial()
        {
            cbMes.Items.Add("Enero");
            cbMes.Items.Add("Febrero");
            cbMes.Items.Add("Marzo");
            cbMes.Items.Add("Abril");
            cbMes.Items.Add("Mayo");
            cbMes.Items.Add("Junio");
            cbMes.Items.Add("Julio");
            cbMes.Items.Add("Agosto");
            cbMes.Items.Add("Septiembre");
            cbMes.Items.Add("Octubre");
            cbMes.Items.Add("Noviembre");
            cbMes.Items.Add("Diciembre");
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            FiltroPagosMesXYear();
        }

        private void FiltroPagosMesXYear()
        {
            String year = cbPagosYearGrafico.Text;

            if (cbPagosYearGrafico.SelectedItem != null)
            {
                using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
                {
                    var mes = (from a in db.sp_obtenerMontoCanceladoMeses(year)
                                      select a.Mes).ToList();
                    var total = (from a in db.sp_obtenerMontoCanceladoMeses(year)
                               select a.Total_cancelado).ToList();

                    graficoPagosMesesPorYear.Series[0].Points.DataBindXY(mes, total);

                }

            }

        }

        private void CargarUltimosClientes()
        {
            using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {
                var ultimosClientes = (from a in db.sp_UltimosConsumidores()
                                       select a).ToList();
                foreach ( var i in ultimosClientes)
                {
                    dtgUltimosConumidores.Rows.Add(i.Nombre_Completo, i.Comunidad);
                }
            }
        }
        private void CargarUltimosPagos()
        {
            using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {
                var ultimosClientes = (from a in db.sp_UltimosPagos()
                                       select a).ToList();
                foreach (var i in ultimosClientes)
                {
                    dtgUltimosPagos.Rows.Add(i.Nombre_Completo, i.Monto, i.Monto_a_Cancelado, i.Impuesto);
                }
            }
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFiltro_MouseHover(object sender, EventArgs e)
        {
            boton.BotonAzulOscuro = btnFiltro;
            color.AzulOscuro(boton);
        }

        private void btnFiltro_MouseLeave(object sender, EventArgs e)
        {
            btnFiltro.BackColor = Color.White;
            btnFiltro.ForeColor = Color.Black;
        }

        private void btnFiltro_MouseMove(object sender, MouseEventArgs e)
        {
            boton.BotonAzulOscuro = btnFiltro;
            color.AzulOscuro(boton);
        }

        private void btnBuscarToatlPagos_MouseHover(object sender, EventArgs e)
        {
            boton.BotonAzulOscuro = btnBuscarToatlPagos;
            color.AzulOscuro(boton);
        }

        private void btnBuscarToatlPagos_MouseLeave(object sender, EventArgs e)
        {
            btnBuscarToatlPagos.BackColor = Color.White;
            btnBuscarToatlPagos.ForeColor = Color.Black;
        }

        private void btnBuscarToatlPagos_MouseMove(object sender, MouseEventArgs e)
        {
            boton.BotonAzulOscuro = btnBuscarToatlPagos;
            color.AzulOscuro(boton);
        }

        private void graficoPagosMesesPorYear_MouseHover(object sender, EventArgs e)
        {
            graficoPagosMesesPorYear.BackColor = Color.FloralWhite;
        }

        private void graficoPagosMesesPorYear_MouseLeave(object sender, EventArgs e)
        {
            graficoPagosMesesPorYear.BackColor = Color.White;
        }

        private void graficoPagosMesesPorYear_MouseMove(object sender, MouseEventArgs e)
        {
            graficoPagosMesesPorYear.BackColor = Color.FloralWhite;
        }

        private void graficoComunidadXconsumidor_MouseHover(object sender, EventArgs e)
        {
            graficoComunidadXconsumidor.BackColor = Color.FloralWhite;
        }

        private void graficoComunidadXconsumidor_MouseLeave(object sender, EventArgs e)
        {
            graficoComunidadXconsumidor.BackColor = Color.White;
        }

        private void graficoComunidadXconsumidor_MouseMove(object sender, MouseEventArgs e)
        {
            graficoComunidadXconsumidor.BackColor = Color.FloralWhite;
        }

        private void dtgUltimosPagos_MouseHover(object sender, EventArgs e)
        {
            dtgUltimosPagos.BackgroundColor = Color.FloralWhite;
            dtgUltimosPagos.RowsDefaultCellStyle.BackColor = Color.FloralWhite;
            dtgUltimosPagos.RowsDefaultCellStyle.SelectionBackColor = Color.FloralWhite;
            dtgUltimosPagos.ColumnHeadersDefaultCellStyle.BackColor = Color.FloralWhite;
            dtgUltimosPagos.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FloralWhite;
        }

        private void dtgUltimosPagos_MouseLeave(object sender, EventArgs e)
        {
            dtgUltimosPagos.BackgroundColor = Color.White;
            dtgUltimosPagos.RowsDefaultCellStyle.BackColor = Color.White;
            dtgUltimosPagos.RowsDefaultCellStyle.SelectionBackColor = Color.White;
            dtgUltimosPagos.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dtgUltimosPagos.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
        }

        private void dtgUltimosPagos_MouseMove(object sender, MouseEventArgs e)
        {
            dtgUltimosPagos.BackgroundColor = Color.FloralWhite;
            dtgUltimosPagos.RowsDefaultCellStyle.BackColor = Color.FloralWhite;
            dtgUltimosPagos.RowsDefaultCellStyle.SelectionBackColor = Color.FloralWhite;
            dtgUltimosPagos.ColumnHeadersDefaultCellStyle.BackColor = Color.FloralWhite;
            dtgUltimosPagos.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FloralWhite;
        }

        private void dtgUltimosConumidores_MouseHover(object sender, EventArgs e)
        {
            dtgUltimosConumidores.BackgroundColor = Color.FloralWhite;
            dtgUltimosConumidores.RowsDefaultCellStyle.BackColor = Color.FloralWhite;
            dtgUltimosConumidores.RowsDefaultCellStyle.SelectionBackColor = Color.FloralWhite;
            dtgUltimosConumidores.ColumnHeadersDefaultCellStyle.BackColor = Color.FloralWhite;
            dtgUltimosConumidores.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FloralWhite;
        }

        private void dtgUltimosConumidores_MouseLeave(object sender, EventArgs e)
        {
            dtgUltimosConumidores.BackgroundColor = Color.White;
            dtgUltimosConumidores.RowsDefaultCellStyle.BackColor = Color.White;
            dtgUltimosConumidores.RowsDefaultCellStyle.SelectionBackColor = Color.White;
            dtgUltimosConumidores.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dtgUltimosConumidores.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
        }

        private void dtgUltimosConumidores_MouseMove(object sender, MouseEventArgs e)
        {
            dtgUltimosConumidores.BackgroundColor = Color.FloralWhite;
            dtgUltimosConumidores.RowsDefaultCellStyle.BackColor = Color.FloralWhite;
            dtgUltimosConumidores.RowsDefaultCellStyle.SelectionBackColor = Color.FloralWhite;
            dtgUltimosConumidores.ColumnHeadersDefaultCellStyle.BackColor = Color.FloralWhite;
            dtgUltimosConumidores.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FloralWhite;

        }

        private void pnlReporteGlobal_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnBuscarToatlPagos_Click(object sender, EventArgs e)
        {
            TotalIngresosFiltrados();
        }

        private void btnLimpiarDatosDelFiltro_Click(object sender, EventArgs e)
        {
            cbMes.SelectedIndex = -1;
            cbYear.SelectedIndex = -1;

        }
    }
}
