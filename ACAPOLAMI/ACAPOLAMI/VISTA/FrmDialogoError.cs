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
    public partial class FrmDialogoError : Form
    {
        public FrmDialogoError(string mensaje)
        {
            InitializeComponent();
            lblMessage.Text = mensaje;
        }

        public static void Error(string mensaje)
        {
            FrmDialogoError error = new FrmDialogoError(mensaje);
            error.ShowDialog();
        }

        private void FrmDialogoError_Load(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
