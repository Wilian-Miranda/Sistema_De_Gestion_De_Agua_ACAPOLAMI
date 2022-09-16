using ACAPOLAMI.DAO;
using ACAPOLAMI.DOMINIO;
using ACAPOLAMI.MODELO;
using ACAPOLAMI.NEGOCIO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using TextBox = System.Windows.Forms.TextBox;

namespace ACAPOLAMI.VISTA
{
    public partial class FrmGestionDePagosOptimizados : Form
    {
        public FrmGestionDePagosOptimizados()
        {
            InitializeComponent();
            txtMonto.Text = Properties.Settings.Default["montoBase"].ToString();
        }
        ClsButtonColor button = new ClsButtonColor();
        ButtonColor btn = new ButtonColor();

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnEjecutarAgregadoOptimizado_Click(object sender, EventArgs e)
        {
            if (validarDatosDeCajas())
            {
                //agregando el primer elemento de la lista de consumidores
                txtConsumidor.Text = consumidores[indexListaConsumidores].nombresConsumidor + " " + consumidores[indexListaConsumidores].apellidosConsumidor;
                //cargando datos a la caja de detalles de operaciones de los filtros proporcionados
                cargarDatosDeFiltradoACajaDetallesOperaciones();
                //mostrar el pago por mes si ya está o se agrega el que falte
                verificarPagosRealizadosPorConsumidorPorYearOAgregar(consumidores);

                txtYear.Enabled = false;
                txtMonto.Enabled = false;
                txtDia.Enabled = false;
                btnIzquierda.Enabled = true;
                btnDerecha.Enabled = true;
                btnEjecutarAgregadoOptimizado.Enabled = false;
                btnCancelarEjecucion.Enabled = true;

                btnIzquierda.PerformClick();
            }
        }
        private Boolean validarDatosDeCajas()
        {
            Boolean validar = false;
            if (!txtYear.Text.Trim().Equals("") && !txtMonto.Text.Trim().Equals("") && !txtDia.Text.Trim().Equals(""))
            {
                try
                {
                    Double year = Double.Parse(txtMonto.Text);
                    Double day = Double.Parse(txtDia.Text);
                    validar = true;

                }
                catch (Exception ex)
                {
                    new FrmDialogoError("Valores no válidos han sido ingresados; valor del año y día deben ser enteros positivos." + ex.ToString()).ShowDialog();
                }
            }
            else
            {
                new FrmDialogoError("Datos requeridos vacíos o nulos").ShowDialog();
            }
            return validar;
        }


        //datos de los consumidores que se van a mostrar en la caja de seleccion
        private List<Consumidores> consumidores = new ClsDConsumidores().ConsultarConsumidores().ToList();

        int indexListaConsumidores = 0;

        private void cambiarConsumidorEnCaja(string direccion)
        {
            if (validarDatosDeCajas())
            {
                dtgPagos.Rows.Clear();
                if (direccion.Equals("Derecha"))
                {
                    if (indexListaConsumidores < consumidores.Count)
                    {
                        indexListaConsumidores += 1;
                        if (indexListaConsumidores == consumidores.Count) indexListaConsumidores--;
                        txtConsumidor.Text = consumidores[indexListaConsumidores].nombresConsumidor + " " + consumidores[indexListaConsumidores].apellidosConsumidor;
                        cargarDatosDePagosATabla(consumidores[indexListaConsumidores].idConsumidor, Convert.ToInt16(txtYear.Text));
                    }
                }
                else
                {
                    indexListaConsumidores -= 1;
                    if (indexListaConsumidores == -1) indexListaConsumidores++;
                    txtConsumidor.Text = consumidores[indexListaConsumidores].nombresConsumidor + " " + consumidores[indexListaConsumidores].apellidosConsumidor;
                    cargarDatosDePagosATabla(consumidores[indexListaConsumidores].idConsumidor, Convert.ToInt16(txtYear.Text));
                }
            }
        }

        private void cargarDatosDeFiltradoACajaDetallesOperaciones()
        {
            txtDetalles.Text = String.Format("===========DETALLES DE LAS OPERACIONES EJECUTADAS==========" +
                            Environment.NewLine + Environment.NewLine +
                            "Convenciones: P = total a pagar, C = total cancelado, P = total pendiente, I: total pagado por mora o impuestos, F = fecha de pago" +
                            " Acción: Solo mostrar = ya hay un pago en el mes y solo se muestra, Crear y mostrar = no hay pago en el mes; se crea para el mes y se muestra" +
                            Environment.NewLine + Environment.NewLine +
                            "Datos por defecto utilizados:" +
                            Environment.NewLine +
                            "Año:" + txtYear.Text + " || Monto:$" + txtMonto.Text + " || Estado de pago:" + txtEstado.Text + " || Día de pago:" + txtDia.Text + " de cada mes" +
                            Environment.NewLine + Environment.NewLine +
                            "Obteniendo los consumidores..." +
                            Environment.NewLine + Environment.NewLine);
        }

        private void verificarPagosRealizadosPorConsumidorPorYearOAgregar(List<Consumidores> listaConsumidores)
        {
            using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {
                short year = Convert.ToInt16(txtYear.Text);
                short indice = 1;
                //para cada uno de los consumidores
                foreach (var i in listaConsumidores)
                {
                    //datos del consumidor agregador a la ventana de detalles de operaciones
                    txtDetalles.Text += String.Format("Indice: " + indice + " || " + (i.nombresConsumidor + " " + i.apellidosConsumidor).ToUpper() +
                        " || Código: " + i.idConsumidor + Environment.NewLine + Environment.NewLine);
                    agregarOmostrarPagosPorMes(i.idConsumidor, year, (i.nombresConsumidor + " " + i.apellidosConsumidor));
                    indice++;
                    txtDetalles.Text += Environment.NewLine + Environment.NewLine;
                    ;
                }
                txtDetalles.Text += "Proceso finalizado.";

            }
        }

        private void agregarOmostrarPagosPorMes(int id, int year, String consumidor)
        {
            //se va a verificar que haya pagos en todos los meses del año indicado
            for (int ix = 1; ix < 13; ix++)
            {
                using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
                {
                    //buscar el pago del consumidor en un determinado mes
                    var data = (from a in db.Pagos where a.idConsumidor_FK == id && a.fechaPago.Year == year && a.fechaPago.Month == ix
                                select new
                                {
                                    nombre = (consumidor),
                                    a.monto,
                                    a.montoCancelado,
                                    a.montoPendiente,
                                    a.impuesto,
                                    a.idEstado_FK,
                                    a.fechaPago

                                }).ToList();

                    var nombre = (from a in db.Consumidores
                                  where a.idConsumidor == id
                                  select new
                                  {
                                      nombre = a.nombresConsumidor + " " + a.apellidosConsumidor
                                  }).ToList().First().nombre;
                    //como hay una "tabla" para msotrar los datos se le agregan espacios al nombre hasta que alcance los 33 caracteres
                    //del espacio degisgnado para el nombre
                    for (int c = nombre.Length; c < 40; c++)
                    {
                        nombre += " ";
                    }
                    //si hay datos solo me muestra en la ventana de detalles de operaciones
                    if (data.Count > 0)
                    {
                        //se recorre la consulta filtrada ya por mes (no debe haber mas de un registro)
                        foreach (var iy in data)
                        {
                            //se imprime el detalle del pago
                            txtDetalles.Text += String.Format(ix + " | " + nombre + " | P: $" + iy.monto + " | C: $" + iy.montoCancelado +
                                " | P: $" + iy.montoPendiente + " | I: $" + iy.impuesto + " | F: " + iy.fechaPago + "    Acción: Solo mostrar" + Environment.NewLine);
                        }
                    }
                    else
                    {
                        //se crear la fecha por defecto para cada mes segun el año y el día de pago que se ha definido
                        DateTimePicker date = new DateTimePicker();
                        date.Text = year + "-" + ix + "-" + txtDia.Text;
                        //creando registro de pago cuando no existe para el mes del año indicado
                        try
                        {
                            new ClsDPagos().AgregarPago(Convert.ToDecimal(txtMonto.Text), 0, Convert.ToDecimal(txtPendiente.Text), 0, date.Value, 3, id, false);
                            txtDetalles.Text += String.Format(ix + " | " + nombre + " | P: $" + txtMonto.Text + " | C: $0.0000" +
                            " | P: $" + txtMonto.Text + " | I: $0.0000" + " | F: " + txtDia.Text + "-" + ix + "-" + year + "    Acción: Crear y mostrar" + Environment.NewLine);
                        }
                        catch (Exception ex)
                        {
                            txtDetalles.Text += "ERROR: no sea ha podido generar el pago por defecto. " + Environment.NewLine
                                + "Mas detalles: " + ex.ToString();
                        }

                    }
                }
            }
        }

        private void cargarDatosDePagosATabla(int id, int year)
        {
            using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {
                var data = (from a in db.Pagos where a.idConsumidor_FK == id && a.fechaPago.Year == year
                            select a).ToList();
                if (data.Count > 0)
                {
                    decimal monto = 0;
                    decimal montoCancelado = 0;
                    decimal montoPendiente = 0;
                    decimal impuestos = 0;
                    foreach (var i in data)
                    {
                        dtgPagos.Rows.Add(i.fechaPago, i.Consumidores.nombresConsumidor + " " + i.Consumidores.apellidosConsumidor,
                            i.monto, i.montoCancelado, i.montoPendiente, i.impuesto, i.Estados.nombreEstado, i.fechaPago);
                        monto += i.monto;
                        montoCancelado += (decimal)i.montoCancelado;
                        montoPendiente += (decimal)i.montoPendiente;
                        impuestos += (decimal)i.impuesto;

                    }
                    lblAPagar.Text = "$" + monto;
                    lblCancelado.Text = "$" + montoCancelado;
                    lblPendiente.Text = "$" + montoPendiente;
                    lblImpuesto.Text = "$" + impuestos;
                }
            }
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            cambiarConsumidorEnCaja("Izquierda");
        }
        private void btnDerecha_Click(object sender, EventArgs e)
        {
            cambiarConsumidorEnCaja("Derecha");
        }

        private void ctbCancelarEjecucion_Click(object sender, EventArgs e)
        {
            limpiarDatos();
        }

        private void limpiarDatos()
        {
            limpiarCajas(txtYear,txtDia,txtDetalles,txtConsumidor);
            txtMonto.Text = Properties.Settings.Default["montoBase"].ToString();
            indexListaConsumidores = 0;
            btnEjecutarAgregadoOptimizado.Enabled = true;
            btnCancelarEjecucion.Enabled = false;
            btnIzquierda.Enabled = false;
            btnDerecha.Enabled = false;
            dtgPagos.Rows.Clear();
            txtYear.Enabled = true;
            txtDia.Enabled = true;
            limpiarEtiquetas(lblAPagar, lblCancelado, lblPendiente, lblImpuesto);
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
            txtPendiente.Text = txtMonto.Text;
        }

        private void btnEjecutarAgregadoOptimizado_MouseHover(object sender, EventArgs e)
        {
            aplicarEstilosHoverBotones(btnEjecutarAgregadoOptimizado, "activar");
        }

        private void btnEjecutarAgregadoOptimizado_MouseLeave(object sender, EventArgs e)
        {
            aplicarEstilosHoverBotones(btnEjecutarAgregadoOptimizado, "");
        }

        private void btnEjecutarAgregadoOptimizado_MouseMove(object sender, MouseEventArgs e)
        {
            aplicarEstilosHoverBotones(btnEjecutarAgregadoOptimizado, "activar");
        }

        private void btnCancelarEjecucion_MouseHover(object sender, EventArgs e)
        {
            aplicarEstilosHoverBotones(btnCancelarEjecucion, "activar");
        }

        private void btnCancelarEjecucion_MouseLeave(object sender, EventArgs e)
        {
            aplicarEstilosHoverBotones(btnCancelarEjecucion, "");
        }

        private void btnCancelarEjecucion_MouseMove(object sender, MouseEventArgs e)
        {
            aplicarEstilosHoverBotones(btnCancelarEjecucion, "activar");
        }

        private void aplicarEstilosHoverBotones(System.Windows.Forms.Button botonEnForm, String accion)
        {
            //eventos move y hover
            if (accion == "activar")
            {
                btn.BotonAzulOscuro = botonEnForm;
                button.AzulOscuro(btn);
                botonEnForm.ForeColor = Color.White;
            }
            else
            {
                //quitar estilos
                botonEnForm.BackColor = Color.WhiteSmoke;
                botonEnForm.ForeColor = Color.Black;
            }
        }

        private void limpiarCajas(params System.Windows.Forms.TextBox[] caja)
        {
            foreach (var i in caja)
            {
                i.Text = "";
            }
        }
        private void limpiarEtiquetas(params System.Windows.Forms.Label[] label)
        {
            foreach (var i in label)
            {
                i.Text = "$0.0000";
            }
        }
    }
}
