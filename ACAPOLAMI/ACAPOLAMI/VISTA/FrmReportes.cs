using ACAPOLAMI.MODELO;
using ACAPOLAMI.MODELO.ViewModels;
using ACAPOLAMI.REPORTE;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACAPOLAMI.VISTA
{
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();

        }
        private void definirTipoDeReporte()
        {
            switch (cbTipoReporte.SelectedIndex)
            {
                case 0:
                    generarReporteDeConsumidores();
                    break;
                case 1:
                    generarReporteDePagosPorYear();
                    break;
                case 2:
                    generarGeneralReporteDePagos();
                    break;
                case 3:
                    generarGeneralReporteGlobal();
                    break;
                default:
                        break;
                    
            }
        }
        private void aplicarValidaciones()
        {
            switch (cbTipoReporte.SelectedIndex)
            {
                case 0:
                    txtBuscador.Enabled = false;
                    txtFecha.Enabled = false;
                    cbConsumidores.Enabled = false;
                    limpiar();
                    break;
                case 1:
                    txtBuscador.Enabled = true;
                    txtFecha.Enabled = true;
                    cbConsumidores.Enabled = true;
                    limpiar();
                    break;
                case 2:
                    txtBuscador.Enabled = false;
                    txtFecha.Enabled = true;
                    cbConsumidores.Enabled = false;
                    limpiar();
                    break;
                case 3:
                    txtBuscador.Enabled = false;
                    cbConsumidores.Enabled = false;
                    txtFecha.Enabled = false;
                    limpiar();
                    break;
                default:
                    break;

            }
        }
        private void generarReporteDeConsumidores()
        {
            using(ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {
                var data = db.sp_MostrarConsumidores().ToList();

                rp_consumidores rp = new rp_consumidores();
                rp.Database.Tables[0].SetDataSource(data);
                rp.Refresh();
                crystalReportViewer.ReportSource = rp;
                crystalReportViewer.RefreshReport();
            }
        }

        private void generarReporteDePagosPorYear()
        {
            using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {
                if (cbConsumidores.SelectedIndex != -1 && cbConsumidores.SelectedItem.ToString() != "")
                {
                    if (txtFecha.Text!="" && txtFecha.Text.Trim().Length > 0)
                    {
                        var data = Buscador(1, cbConsumidores.Text + "_" + txtFecha.Text);
                        rp_pagosPorYearConsumidor rp = new rp_pagosPorYearConsumidor();
                        rp.Database.Tables[0].SetDataSource(data);
                        rp.Refresh();
                        crystalReportViewer.ReportSource = rp;
                        crystalReportViewer.RefreshReport();
                    }
                }
            }
        }
        private void generarGeneralReporteGlobal()
        {
            using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {
                var data = datosReporteGlobal();
                rp_reporteGlobal rp = new rp_reporteGlobal();
                rp.Database.Tables[0].SetDataSource(data);
                rp.Refresh();
                crystalReportViewer.ReportSource = rp;
                crystalReportViewer.Refresh();
            }
        }
        private List<CR_ReporteGlobalPorYear> datosReporteGlobal()
        {
            List<CR_ReporteGlobalPorYear> reporte = new List<CR_ReporteGlobalPorYear>();

            using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {
                var data = db.sp_rp_pagosByYear().ToList();
                foreach (var i in data)
                {
                    reporte.Add(
                        new CR_ReporteGlobalPorYear(
                            (int)i.year,
                            (decimal)i.monto,
                            (decimal)i.montoCancelado,
                            (decimal)i.montoPendiente,
                            (decimal)i.impuesto));
                }
            }
            return reporte;
        }
        private void generarGeneralReporteDePagos()
        {
            using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {
                var data = generarReportePagosPorCuatrimestre();
                rp_reporteGeneralPorYear rp = new rp_reporteGeneralPorYear();
                rp.Database.Tables[0].SetDataSource(data);
                rp.Refresh();
                crystalReportViewer.ReportSource = rp;
                crystalReportViewer.Refresh();
            }
        }

        public List<CR_Pagos> Buscador(int tipo, string busqueda = null)
        {
            List<CR_Pagos> data = new List<CR_Pagos>();
            using (ACAPOLAMIEntities bd = new ACAPOLAMIEntities())
            {
                //Consulta
                var buscar = (
                    from consumidor in bd.Consumidores
                    from pagos in bd.Pagos
                    from estado in bd.Estados
                    where pagos.idConsumidor_FK == consumidor.idConsumidor
                    && pagos.idEstado_FK == estado.idEstado

                    select new CR_Pagos
                    {
                        Id = pagos.idPago,
                        Nombres = consumidor.nombresConsumidor,
                        Apellidos = consumidor.apellidosConsumidor,
                        Monto = pagos.monto,
                        Cancelado = (decimal)pagos.montoCancelado,
                        Pendiente = (decimal)pagos.montoPendiente,
                        Impuesto = (decimal)pagos.impuesto,
                        Fecha = pagos.fechaPago,
                        Estado = estado.nombreEstado
                    });
                
                if (busqueda != null && !busqueda.Equals("") && tipo == 1)
                {
                    Console.WriteLine(busqueda);
                    String nombre = busqueda.Split('_')[0];
                    String year = busqueda.Split('_')[1];
                    List<CR_Pagos> filtrado = new List<CR_Pagos>();
                    foreach (var i in buscar)
                    {
                        //Console.WriteLine(i.Fecha);
                        if (i.Nombres.ToLower().Contains(nombre.ToLower())
                            || i.Apellidos.ToLower().Contains(nombre.ToLower())
                            || (i.Nombres + " " + i.Apellidos).ToLower().Contains(nombre.ToLower()))
                        {
                            //Console.WriteLine(i.Fecha.ToString().Split('/')[2].Substring(0, 4));
                            if (i.Fecha.ToString().Split('/')[2].Substring(0, 4) == year)
                            {
                                filtrado.Add(i);
                            }
                        }
                    }
                    //Pasamos la lista de consultas al dataGridView
                    if (filtrado != null) data = filtrado;
                    foreach (var i in filtrado)
                    {
                        Console.WriteLine(i);
                    }
                }

            }
            return data;
        }
        #region reporte de pagos de consumidor por año
        /*validaciones para generar el array de pagos generales*/
        private List<PagosGeneral> generarReportePagosPorCuatrimestre()
        {
            List<PagosGeneral> reporte = new List<PagosGeneral>();
            //obteniendo mes y año
            try
            {
                String mesInicio;
                int year;
                if (!txtFecha.Text.Equals("") && txtFecha.Text.Trim().Length>0 && txtFecha.Text.Contains("_"))
                {
                    try
                    {
                        year = Convert.ToInt32(txtFecha.Text.Split('_')[0]);
                        mesInicio = txtFecha.Text.Split('_')[1];
                        Console.WriteLine(year+" "+mesInicio);
                        if (mesInicio == "I" || mesInicio == "i") {
                            reporte = generarArregloPagos(1, year,new string[] {"Enero", "Febrero", "Marzo", "Abril"});
                        }
                        else if (mesInicio == "II" || mesInicio == "ii")
                        {
                            reporte = generarArregloPagos(5, year, new string[] { "Mayo", "Junio", "Julio", "Agosto" });
                        }
                        else if (mesInicio == "III" || mesInicio == "iii")
                        {
                            reporte = generarArregloPagos(9, year, new string[] { "Septiembre", "Octubre", "Noviembre", "Diciembre" });
                        }
                    }
                    catch(Exception ex)
                    {
                        new FrmDialogoError("Valores no válidos.\n"+ex.ToString()).ShowDialog();
                    }
                }
                else
                {
                    new FrmDialogoError("Formato y/o valores de fecha nulos o vacíos.").ShowDialog();
                }
            }
            catch (Exception ex) {
                new FrmDialogoError("Error al validar datos al generar el reporte general de pagos.\n" + ex.ToString()).ShowDialog();
            }
            return reporte;
        }

        /*Genera un array con los pagos por cuatrimestre de cada consumidor*/
        private List<PagosGeneral> generarArregloPagos(int mesInicial, int Year, String[] meses)
        {
            List<PagosGeneral> reporte = new List<PagosGeneral>();
            using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {
                var consumidores = (from a in db.Consumidores
                                    select new
                                    {
                                        a.idConsumidor,
                                        nombres = (a.nombresConsumidor + " " + a.apellidosConsumidor)
                                    }).ToList();
                //obteniendo los pagos cuatrimestrales por cada consumidor
                foreach (var i in consumidores)
                {
                    reporte.Add(new PagosGeneral(obtenerPagosPorCuatrimestrePorConsumidor(i.idConsumidor, mesInicial, Year, meses)));
                }

            }
            return reporte;
        }
        /*Obtiene los pagos por cuatrimestre de cada consumidor*/
        private ReporteGeneralPagos obtenerPagosPorCuatrimestrePorConsumidor(int idConsumidor,int mesInicio, int year, String[] meses)
        {
            ReporteGeneralPagos reporte = new ReporteGeneralPagos();
            using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {
                var nombre = (from a in db.Consumidores
                                 where a.idConsumidor == idConsumidor
                                    select new
                                    {
                                        nombre = (a.nombresConsumidor + " " + a.apellidosConsumidor)
                                    }).ToList();
                reporte.Nombre = nombre.FirstOrDefault().nombre.ToString();
                reporte.Pago1 = obtenerPagosPorMes(idConsumidor,mesInicio,year);
                reporte.Pago2 = obtenerPagosPorMes(idConsumidor, mesInicio+1, year);
                reporte.Pago3 = obtenerPagosPorMes(idConsumidor, mesInicio+2, year);
                reporte.Pago4 = obtenerPagosPorMes(idConsumidor, mesInicio+3, year);
                reporte.Mes1 = meses[0];
                reporte.Mes2 = meses[1];
                reporte.Mes3 = meses[2];
                reporte.Mes4 = meses[3];
                reporte.Year = year;
            }
            return reporte;
        }
        /*Obtiene el monto cancelado, pendiente e impuesto de un consumidor en un año*/
        private REPORTE.Pagos obtenerPagosPorMes(int idConsumidor, int mes, int year)
        {
            REPORTE.Pagos _pago = new REPORTE.Pagos();
            using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {
                var pagoPorMes = (from a in db.Pagos
                                 where a.idConsumidor_FK == idConsumidor 
                                 && a.fechaPago.Month == mes
                                 && a.fechaPago.Year == year
                                 select new { 
                                     a.montoCancelado,
                                     a.montoPendiente,
                                     a.impuesto
                                 }).ToList();
                if (pagoPorMes.Count > 0)
                {
                    foreach (var i in pagoPorMes)
                    {
                        _pago.Cancelado = i.montoCancelado;
                        _pago.Pendiente = i.montoPendiente;
                        _pago.Impuesto = i.impuesto;
                    }
                }
                else
                {
                    _pago.Cancelado = 0;
                    _pago.Pendiente = 0;
                    _pago.Impuesto = 0;
                }

            }
            return _pago;
        }
        #endregion



        private void cbTipoReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            aplicarValidaciones();
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {

        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            using(ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {
                var consumidor = (from a in db.Consumidores
                                  where (a.nombresConsumidor+" "+a.apellidosConsumidor).Contains(txtBuscador.Text)
                                  select new
                                  {
                                      a.idConsumidor,
                                      nombres = (a.nombresConsumidor+" "+a.apellidosConsumidor)
                                  }).ToList();
                if (consumidor.Count > 0)
                {
                    cbConsumidores.DataSource = consumidor;
                    cbConsumidores.DisplayMember = "nombres";
                    cbConsumidores.ValueMember = "idConsumidor";
                    cbConsumidores.SelectedIndex = 0;
                    cbConsumidores.DroppedDown = true;
                }
            }
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            definirTipoDeReporte();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void limpiar()
        {
            cbConsumidores.DroppedDown = false;
            txtBuscador.Text = "";
            cbConsumidores.ResetText();
            cbConsumidores.SelectedIndex = -1;
            txtFecha.Text = "";
        }
    }
}
