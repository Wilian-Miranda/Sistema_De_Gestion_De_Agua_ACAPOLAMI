using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACAPOLAMI.VISTA
{
    public partial class FrmDialogoExito : Form
    {
        public FrmDialogoExito(string mensaje)
        {
            InitializeComponent();
            lblMensaje.Text = mensaje;
        }

        public static void Confirmar(string mensaje)
        {
            FrmDialogoExito exito = new FrmDialogoExito(mensaje);
            exito.ShowDialog();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmDialogoExito_Load(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
        }
    }
}
