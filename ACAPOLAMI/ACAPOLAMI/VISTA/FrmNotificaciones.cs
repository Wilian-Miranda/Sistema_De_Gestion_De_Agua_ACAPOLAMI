using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACAPOLAMI.VISTA
{
    public partial class FrmNotificaciones : Form
    {
        public FrmNotificaciones()
        {
            InitializeComponent();
        }

        public string Titulo { get; set; }
        public string Mensaje { get; set; }
        public enum TipoAlerta { Realizado, Advertencia, Error, Mensaje };
        public int Duracion { get; set; }
        private int Vertical;
        private int Horizontal;

        //Inicializar las variables.
        public FrmNotificaciones(string titulo, string mensaje, TipoAlerta tipo)
        {
            InitializeComponent();
            Titulo = titulo;
            Mensaje = mensaje;
            Vertical = Screen.PrimaryScreen.Bounds.Height - this.Height - 50;
            Horizontal = this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 10;
            Duracion = 5;
            Opacity = 0;


            //Comprobar El Tipo de Mensaje
            switch (tipo)
            {
                case TipoAlerta.Realizado:
                    this.BackColor = Color.FromArgb(44, 139, 89);
                    txtMensaje.BackColor = Color.FromArgb(44, 139, 89);
                    pcbImagen.Image = Properties.Resources.Sucesswhite;
                    break;
                case TipoAlerta.Error:
                    this.BackColor = Color.FromArgb(181, 41, 42);
                    txtMensaje.BackColor = Color.FromArgb(181, 41, 42);
                    pcbImagen.Image = Properties.Resources.cancelWhite;
                    break;
                case TipoAlerta.Advertencia:
                    this.BackColor = Color.FromArgb(255, 131, 5);
                    txtMensaje.BackColor = Color.FromArgb(255, 131, 5);
                    pcbImagen.Image = Properties.Resources.WarnigWhite;
                    break;
                case TipoAlerta.Mensaje:
                    this.BackColor = Color.FromArgb(132, 132, 132);
                    txtMensaje.BackColor = Color.FromArgb(132, 132, 132);
                    pcbImagen.Image = Properties.Resources.WarnigWhite;
                    break;
                default:
                    this.BackColor = Color.FromArgb(44, 139, 89);
                    txtMensaje.BackColor = Color.FromArgb(44, 139, 89);
                    pcbImagen.Image = Properties.Resources.Sucesswhite;
                    break;
            }

            lbntitulo.Text = this.Titulo;
            txtMensaje.Text = this.Mensaje;
            ShowInTaskbar = false;

        }
        private void CerrandoAnimacion()
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity = this.Opacity - 0.05;
            }
            else
            {
                this.Close();
            }
        }
        private void MostrandoAnimacion()
        {
            if (this.Opacity <= 0.90)
            {
                this.Opacity = this.Opacity + 0.05;

            }
            else
            {
                this.Mostrando.Stop();
            }
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            if (Duracion > 0)
            {
                Duracion -= 1;
            }
            else
            {
                Temporizador.Interval = 100;
                CerrandoAnimacion();
            }
        }

        private void Mostrando_Tick(object sender, EventArgs e)
        {
            MostrandoAnimacion();
        }

        private void Cerrando_Tick(object sender, EventArgs e)
        {
            CerrandoAnimacion();
        }

        //Reactivar el formulario si el usuario pasa el mouse por la ventana.
        private void FrmNotificaciones_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.Opacity < 0.90)
            {
                this.Opacity = 0.90;
                Temporizador.Enabled = false;
            }
            else
            {
                Temporizador.Enabled = false;
            }
        }

        //Reactivar el el temporizador que controla la animacion de cierre.
        private void FrmNotificaciones_MouseLeave(object sender, EventArgs e)
        {
            if (Temporizador.Enabled == false)
            {
                Temporizador.Enabled = true;
                this.Duracion += 3;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Cerrando.Enabled = true;
        }

        //Muestra la notificacion en la barra de tareas y en las notificaciones del sistema
        public void MostrarNotificacion()
        {
            iconoNotificacion.Text = "Se han encontrado acciones en los registros";
            iconoNotificacion.Visible = true;
            iconoNotificacion.BalloonTipTitle = Titulo;
            iconoNotificacion.BalloonTipText = Mensaje;
            iconoNotificacion.BalloonTipIcon = ToolTipIcon.Info;
            iconoNotificacion.ShowBalloonTip(10000);
        }

        private void FrmNotificaciones_Load(object sender, EventArgs e)
        {
            this.Top = Vertical;
            this.Left = Horizontal;
            Mostrando.Enabled = true;
            MostrarNotificacion();
        }
    }
}
