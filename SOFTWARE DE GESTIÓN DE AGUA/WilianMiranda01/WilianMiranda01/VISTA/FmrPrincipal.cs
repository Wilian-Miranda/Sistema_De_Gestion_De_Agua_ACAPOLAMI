using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace WilianMiranda01.VISTA
{


    public partial class FmrPrincipal : Form
    {
        FrmClientes data = new FrmClientes();
        //variable para almacenar el botón actual
        public IconButton btnEnUso;
        //panel para aplicar el borde del lado izquierdo del botón
        public Panel bordeIzquierdoDelBoton;

        public Boolean estado = false;

        //constructor
        public FmrPrincipal()
        {
            InitializeComponent();
            //inicializando el borde izquierdo del botón
            bordeIzquierdoDelBoton = new Panel();
            //tamaño y altura del panel
            bordeIzquierdoDelBoton.Size = new Size(15, 60);
            //agregando el borde izquierdo al los botones del panel menú
            pnlMenu.Controls.Add(bordeIzquierdoDelBoton);

            if (estado == true)
            {
                Reiniciar();
            }
        }




        private void FmrPrincipal_Load(object sender, EventArgs e)
        {


        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            /*double lectura = Convert.ToDouble(txtLecturatxtInter1.Text);
            CalcularConsumo(lectura);*/

        }
        /*
        private void CalcularConsumo(double lectura)
        {
            double pagoBase = Convert.ToDouble(txtPagoBase.Text);

            int i1, i2, i3;
            i1 = Convert.ToInt32(txtInter1.Text);
            i2 = Convert.ToInt32(txtInter2.Text);
            i3 = Convert.ToInt32(txtInter3.Text);



            if (lectura <= i1)
            {
                txtResultado.Text = (pagoBase + ((0 + lectura)*0.00)).ToString();
            }
            else if (lectura > i1 && lectura <= i2)
            {
                txtResultado.Text = (pagoBase + ((-i1 + lectura)*0.29)+((i1) * 0.00)).ToString();
            }
            else if (lectura > i2 && lectura <= i3)
            {
                txtResultado.Text = (pagoBase + ((-i2 + lectura)*0.39)+((i2-i1) * 0.29) 
                                  + ((i1) * 0.00)).ToString();
            }
            else
            {
                txtResultado.Text = (pagoBase + ((-i3 + lectura) * 0.49)+((i3-i2)*0.39) + ((i2-i1) * 0.29)
                                  + ((i1) * 0.00)).ToString();
            }
        }*/

        private void btnPagos_Click(object sender, EventArgs e)
        {
            // Se pasa como parametro el objeto sender; el boton que es seleccionado, y un color.
            //ClsPersonalizacionDeBotones PerBoton = new ClsPersonalizacionDeBotones();
            BotonActivo(sender, Color.Thistle);
            AbrirFormEnPanel<FrmPagos>();

        }

        private void btnPrincipal_Click_1(object sender, EventArgs e)
        {
            // Se pasa como parametro el objeto sender; el boton que es seleccionado, y un color.
            //ClsPersonalizacionDeBotones PerBoton = new ClsPersonalizacionDeBotones();
            BotonActivo(sender, Color.Thistle);
        }

        private void btnAjustes_Click_1(object sender, EventArgs e)
        {
            // Se pasa como parametro el objeto sender; el boton que es seleccionado, y un color.
            //ClsPersonalizacionDeBotones PerBoton = new ClsPersonalizacionDeBotones();
            BotonActivo(sender, Color.Thistle);
        }

        private void btnNotificaciones_Click_1(object sender, EventArgs e)
        {
            // Se pasa como parametro el objeto sender; el boton que es seleccionado, y un color.
            //ClsPersonalizacionDeBotones PerBoton = new ClsPersonalizacionDeBotones();
            AbrirFormEnPanel<FrmActividades>();
            BotonActivo(sender, Color.Thistle);
        }

        private void btnReporte_Click_1(object sender, EventArgs e)
        {
            // Se pasa como parametro el objeto sender; el boton que es seleccionado, y un color.
            //ClsPersonalizacionDeBotones PerBoton = new ClsPersonalizacionDeBotones();
            BotonActivo(sender, Color.Thistle);
        }

        private void btnClientes_Click_1(object sender, EventArgs e)
        {
            // Se pasa como parametro el objeto sender; el boton que es seleccionado, y un color.
            //ClsPersonalizacionDeBotones PerBoton = new ClsPersonalizacionDeBotones();
            BotonActivo(sender, Color.Thistle);

            AbrirFormEnPanel<FrmClientes>();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void DesactivarResaltado()
        {
            //verificando que el boton actual sea diferente de nulo
            if (btnEnUso != null)
            {
                //RETORNANDO A LAS CONFIGURACIONES POR DEFECTO
                //retornando el color por defecto del boton
                btnEnUso.BackColor = Color.FromArgb(0, 192, 192);
                //colocando el color por defecto del icono
                btnEnUso.IconColor = Color.Cyan;
                //Aliniando el texto al centro
                btnEnUso.TextAlign = ContentAlignment.MiddleLeft;
                //cambiado relacion de texto a imagen antes de texto
                btnEnUso.TextImageRelation = TextImageRelation.ImageBeforeText;
                //Aliniando el icono a la izquierda
                btnEnUso.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        //Metodo void para resaltar el botón activo
        public void BotonActivo(object btnActivo, Color color)
        {
            //verificando que el botón sea diferente de nulo
            if (btnActivo != null)
            {
                //invocando el método de desactivar resaltado para desactivar el resaltado
                //en el boton anterior
                DesactivarResaltado();
                //BOTÓN
                btnEnUso = (IconButton)btnActivo;
                //cambiando el color de fondo del color
                btnEnUso.BackColor = Color.Teal;
                //color del icono
                btnEnUso.IconColor = color;
                //Aliniando el texto al centro
                btnEnUso.TextAlign = ContentAlignment.MiddleCenter;
                //cambiado relacion de texto a texto antes de imagen
                btnEnUso.TextImageRelation = TextImageRelation.TextBeforeImage;
                //Aliniando el icono a la derecha
                btnEnUso.ImageAlign = ContentAlignment.MiddleRight;


                //BORDE IZQUIERDO DEL BOTON
                //se cambia el borde izquierdo de acuerdo al parámetro color de método
                bordeIzquierdoDelBoton.BackColor = color;
                //nueva ubicacion en el eje x y obteniedo la ubicacion en el eje y del boton actual
                bordeIzquierdoDelBoton.Location = new Point(0, btnEnUso.Location.Y);
                //visibilidad en verdader
                bordeIzquierdoDelBoton.Visible = true;
                //trayendo al frente
                bordeIzquierdoDelBoton.BringToFront();


            }

        }

        internal void BotonActivo(object sender)
        {
            throw new NotImplementedException();
        }

        private void pnlFormularioHijo_Paint(object sender, PaintEventArgs e)
        {

        }

        /* private void AbrirFormEnPanel(object frmHijo)
         {

             if (this.pnlPanelPadre.Controls.Count > 0)
                 this.pnlPanelPadre.Controls.RemoveAt(0);
             Form F = frmHijo as Form;
             F.TopLevel = false;
             F.Dock = DockStyle.Fill;
             this.pnlPanelPadre.Controls.Add(F);
             this.pnlPanelPadre.Tag = F;
             F.Show();

             if (pnlPanelPadre.Controls.Contains(F) == true)
             {
                 MessageBox.Show("Hay un form abierto");
             }
         }*/
        private Form formulario;
        private void AbrirFormEnPanel<Miform>() where Miform: Form, new()
        {
            if(formulario != null)
            {
                formulario.Close();
            }
            
            formulario = pnlPanelPadre.Controls.OfType<Miform>().FirstOrDefault();
            if(formulario == null)
            {
                formulario = new Miform();
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                pnlPanelPadre.Controls.Add(formulario);
                pnlPanelPadre.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        public void ptrLogo_Click(object sender, EventArgs e)
        {
            if (formulario != null)
            {
                formulario.Close();
                Reiniciar();
                //MessageBox.Show("Le das click :v");
            }

        }

        public void Reiniciar()
        {
            //pnlPanelPadre.Controls.Clear();
            DesactivarResaltado();
            bordeIzquierdoDelBoton.Visible = false;
        }

        private void btnCerrarAplicacion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizarAplicacion_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Width == 200)
            {
                btnInicio.Dock = DockStyle.Fill;
                bntMinimizarMenu.Dock = DockStyle.Left;
                pnlMenu.Width = 53;
                BorrarTextoBotonPanelMenu();
                ActivarBorde();

                
            }
            else
            {
                pnlMenu.Width = 200;
                bntMinimizarMenu.Dock = DockStyle.Right;
                BorrarTextoBotonPanelMenu();
                ActivarBorde();

            }


        }

        private void ActivarBorde()
        {
            if (pnlMenu.Width == 53)
            {
                bordeIzquierdoDelBoton.Size = new Size(3, 60);
            }
            else
            {
                bordeIzquierdoDelBoton.Size = new Size(15, 60);
            }
        }

        private void BorrarTextoBotonPanelMenu()
        {
            if (pnlMenu.Width == 53)
            {
                btnPrincipal.Text = "";
                btnNotificaciones.Text = "";
                btnPagos.Text = "";
                btnReporte.Text = "";
                btnAjustes.Text = "";
                btnClientes.Text = "";
            }
            else
            {
                btnPrincipal.Text = "Dashboard";
                btnNotificaciones.Text = "Actividad";
                btnPagos.Text = "Pagos";
                btnReporte.Text = "Reporte";
                btnAjustes.Text = "Ajustes";
                btnClientes.Text = "Clientes";
            }
        }

        private void pnlPanelPadre_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

