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
    public partial class FrmDialogoAdvertencia : Form
    {
        public FrmDialogoAdvertencia(string mensaje)
        {
            InitializeComponent();
            lblMensaje.Text = mensaje;
        }

        public static void Advertir(string mensaje)
        {
            FrmDialogoAdvertencia advertencia = new FrmDialogoAdvertencia(mensaje);
            advertencia.ShowDialog();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FrmDialogoError_Load(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
        }
    }
}
