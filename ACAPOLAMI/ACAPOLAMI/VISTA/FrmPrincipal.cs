using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using ACAPOLAMI.NEGOCIO;
using ACAPOLAMI.DOMINIO;
using ACAPOLAMI.VISTA;
using ProyectoCiclo3.VISTA;

namespace WilianMiranda01.VISTA
{
    public partial class FmrPrincipal : Form
    {
        Form1 login = new Form1();
        FrmClientes data = new FrmClientes();
        //variable para almacenar el botón actual
        public Button btnEnUso;
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

        ClsButtonColor button = new ClsButtonColor();
        ButtonColor btn = new ButtonColor();

        private void FmrPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            // Se pasa como parametro el objeto sender; el boton que es seleccionado, y un color.
            BotonActivo(sender, Color.White);
            AbrirFormEnPanel<FrmPagos>();

        }

        private void btnPrincipal_Click_1(object sender, EventArgs e)
        {
            // Se pasa como parametro el objeto sender; el boton que es seleccionado, y un color.
            BotonActivo(sender, Color.White);
            AbrirFormEnPanel<FrmDashboard>();
        }

        private void btnAjustes_Click_1(object sender, EventArgs e)
        {
            // Se pasa como parametro el objeto sender; el boton que es seleccionado, y un color.
            BotonActivo(sender, Color.White);
        }

        private void btnNotificaciones_Click_1(object sender, EventArgs e)
        {
            // Se pasa como parametro el objeto sender; el boton que es seleccionado, y un color.
            AbrirFormEnPanel<FrmActividad>();
            BotonActivo(sender, Color.White);
        }

        private void btnReporte_Click_1(object sender, EventArgs e)
        {
            // Se pasa como parametro el objeto sender; el boton que es seleccionado, y un color.
            BotonActivo(sender, Color.White);
        }

        private void btnClientes_Click_1(object sender, EventArgs e)
        {
            // Se pasa como parametro el objeto sender; el boton que es seleccionado, y un color.
            BotonActivo(sender, Color.White);

            AbrirFormEnPanel<FrmClientes>();
        }

        public void DesactivarResaltado()
        {
            //verificando que el boton actual sea diferente de nulo
            if (btnEnUso != null)
            {
                //RETORNANDO A LAS CONFIGURACIONES POR DEFECTO
                //retornando el color por defecto del boton
                btnEnUso.BackColor = Color.FromArgb(62, 133, 206);
                //Aliniando el texto al centro
                btnEnUso.TextAlign = ContentAlignment.MiddleLeft;
                //cambiado relacion de texto a imagen antes de texto
                btnEnUso.TextImageRelation = TextImageRelation.ImageBeforeText;
                //Aliniando el icono a la izquierda
                btnEnUso.ImageAlign = ContentAlignment.MiddleCenter;
                btnEnUso.FlatAppearance.BorderSize = 0;
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
                btnEnUso = (Button)btnActivo;
                //cambiando el color de fondo del color
                btnEnUso.BackColor = Color.FromArgb(51, 124, 173);
                //Aliniando el texto al centro
                btnEnUso.TextAlign = ContentAlignment.MiddleCenter;
                //cambiado relacion de texto a texto antes de imagen
                btnEnUso.TextImageRelation = TextImageRelation.TextBeforeImage;
                //Aliniando el icono a la derecha
                if (pnlMenu.Width == 53)
                {
                    btnEnUso.ImageAlign = ContentAlignment.MiddleCenter;
                }
                else
                {
                    btnEnUso.ImageAlign = ContentAlignment.MiddleRight;
                }
                btnEnUso.FlatAppearance.BorderSize = 2;


                //BORDE IZQUIERDO DEL BOTON
                //se cambia el borde izquierdo de acuerdo al parámetro color de método
                bordeIzquierdoDelBoton.BackColor = Color.White;
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
                btnInicio.Image = ACAPOLAMI.Properties.Resources.gif;
                bntMinimizarMenu.Dock = DockStyle.Left;
                pnlMenu.Width = 53;
                BorrarTextoBotonPanelMenu();
                ActivarBorde();
                AlinearIconosMenu1();
            }

            else
            {
                btnInicio.Image = ACAPOLAMI.Properties.Resources.gif2;
                pnlMenu.Width = 200;
                bntMinimizarMenu.Dock = DockStyle.Right;
                BorrarTextoBotonPanelMenu();
                ActivarBorde();
                AlinearIconosMenu2();
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
                btnCerrarSesión.Text = "";
                lblNombreUSuario.Visible = false;
            }

            else
            {
                btnPrincipal.Text = "Dashboard";
                btnNotificaciones.Text = "Actividad";
                btnPagos.Text = "Pagos";
                btnReporte.Text = "Reportes";
                btnAjustes.Text = "Ajustes";
                btnClientes.Text = "Clientes";
                btnCerrarSesión.Text = "Cerrar Sesión";
                lblNombreUSuario.Visible = true;
            }
        }

        private void AlinearIconosMenu1()
        {
            if (pnlMenu.Width == 53)
            {
                if (btnEnUso != null)
                {
                    btnEnUso.ImageAlign = ContentAlignment.MiddleCenter;
                }
            }

        }
        private void AlinearIconosMenu2()
        {
            if (pnlMenu.Width == 200)
            {
                if (btnEnUso != null)
                {
                    btnEnUso.ImageAlign = ContentAlignment.MiddleRight;
                    btnEnUso.TextAlign = ContentAlignment.MiddleCenter;
                    btnEnUso.TextImageRelation = TextImageRelation.TextBeforeImage;
                }
                if (formulario != null)
                {
                    btnEnUso.ImageAlign = ContentAlignment.MiddleCenter;
                    btnEnUso.TextAlign = ContentAlignment.MiddleCenter;
                    btnEnUso.TextImageRelation = TextImageRelation.ImageBeforeText;
                }
            }

        }

        private void tmrTiempo_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        int posX = 0;
        int posY = 0;
        private void pnlCabezaPrincipal_MouseMove(object sender, MouseEventArgs e)
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

        private void btnCerrarAplicacion_MouseHover(object sender, EventArgs e)
        {
            btn.BotonRojo = btnCerrarAplicacion;
            button.Rojo(btn);
        }

        private void btnCerrarAplicacion_MouseLeave(object sender, EventArgs e)
        {
            btn.BotonAzulOscuro = btnCerrarAplicacion;
            button.AzulOscuro(btn);
        }

        private void btnCerrarAplicacion_MouseMove(object sender, MouseEventArgs e)
        {
            btn.BotonRojo = btnCerrarAplicacion;
            button.Rojo(btn);
        }

        private void btnMinimizarAplicacion_MouseHover(object sender, EventArgs e)
        {
            btn.BotonAzulClaro = btnMinimizarAplicacion;
            button.AzulClaro(btn);
        }

        private void btnMinimizarAplicacion_MouseLeave(object sender, EventArgs e)
        {
            btn.BotonAzulOscuro = btnMinimizarAplicacion;
            button.AzulOscuro(btn);
        }

        private void btnMinimizarAplicacion_MouseMove(object sender, MouseEventArgs e)
        {
            btn.BotonAzulClaro = btnMinimizarAplicacion;
            button.AzulClaro(btn);
        }

        private void btnCerrarSesión_MouseHover(object sender, EventArgs e)
        {
            btn.BotonRojo = btnCerrarSesión;
            button.Rojo(btn);
        }

        private void btnCerrarSesión_MouseLeave(object sender, EventArgs e)
        {
            btn.BotonAzulOscuro = btnCerrarSesión;
            button.AzulOscuro(btn);
        }

        private void btnCerrarSesión_MouseMove(object sender, MouseEventArgs e)
        {
            btn.BotonRojo = btnCerrarSesión;
            button.Rojo(btn);
        }

        private void btnCerrarSesión_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.ptrLogo_Click(sender,e);
            this.Hide();
            login.Show();
        }
    }
}