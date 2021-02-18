using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace WilianMiranda01.VISTA
{


    public partial class FmrPrincipal : Form
    {
        //variable para almacenar el botón actual
        private IconButton btnActual;
        //panel para aplicar el borde del lado izquierdo del botón
        private Panel bordeIzquierdoDelBoton;

        //constructor
        public FmrPrincipal()
        {
            InitializeComponent();
            //inicializando el borde izquierdo del botón
            bordeIzquierdoDelBoton = new Panel();
            //tamaño y altura del botón
            bordeIzquierdoDelBoton.Size = new Size(15,60);

            //agregando el borde izquierdo al los botones del panel menú
            pnlMenu.Controls.Add(bordeIzquierdoDelBoton);
        }

        //métodos
        //Metodo void para resaltar el botón activo
        private void BotonActivo(object btnActivo, Color color)
        {
            //verificando que el botón sea diferente de nulo
            if (btnActivo != null)
            {
                //invocando el método de desactivar resaltado para desactivar el resaltado
                //en el boton anterior
                DesactivarResaltado();
                //BOTÓN
                btnActual = (IconButton)btnActivo;
                //cambiando el color de fondo del color
                btnActual.BackColor = Color.Teal;
                //color del icono
                btnActual.IconColor = color;
                //Aliniando el texto al centro
                btnActual.TextAlign = ContentAlignment.MiddleCenter;
                //cambiado relacion de texto a texto antes de imagen
                btnActual.TextImageRelation = TextImageRelation.TextBeforeImage;
                //Aliniando el icono a la derecha
                btnActual.ImageAlign = ContentAlignment.MiddleRight;


                //BORDE IZQUIERDO DEL BOTON
                //se cambia el borde izquierdo de acuerdo al parámetro color de método
                bordeIzquierdoDelBoton.BackColor = color;
                //nueva ubicacion en el eje x y obteniedo la ubicacion en el eje y del boton actual
                bordeIzquierdoDelBoton.Location = new Point(0, btnActual.Location.Y);
                //visibilidad en verdader
                bordeIzquierdoDelBoton.Visible = true;
                //trayendo al frente
                bordeIzquierdoDelBoton.BringToFront();
            }
        }

        //MÉTODO PARA DESACTIVAR EL RESALTADO DEL BOTÓN
        private void DesactivarResaltado()
        {
            //verificando que el boton actual sea diferente de nulo
            if (btnActual != null)
            {
                //RETORNANDO A LAS CONFIGURACIONES POR DEFECTO
                //retornando el color por defecto del boton
                btnActual.BackColor = Color.FromArgb(0, 192, 192);
                //colocando el color por defecto del icono
                btnActual.IconColor = Color.Cyan;
                //Aliniando el texto al centro
                btnActual.TextAlign = ContentAlignment.MiddleLeft;
                //cambiado relacion de texto a imagen antes de texto
                btnActual.TextImageRelation = TextImageRelation.ImageBeforeText;
                //Aliniando el icono a la izquierda
                btnActual.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void FmrPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            BotonActivo(sender, Color.Thistle);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            BotonActivo(sender, Color.Thistle);
        }

        private void btnMediciones_Click(object sender, EventArgs e)
        {
            BotonActivo(sender, Color.Thistle);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            BotonActivo(sender, Color.Thistle);
        }

        private void btnNotificaciones_Click(object sender, EventArgs e)
        {
            BotonActivo(sender, Color.Thistle);
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            BotonActivo(sender, Color.Thistle);
        }
    }
}
