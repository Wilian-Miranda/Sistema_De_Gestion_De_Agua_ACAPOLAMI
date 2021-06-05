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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void frmActividad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cddActividad.Sucesos' Puede moverla o quitarla según sea necesario.
            this.sucesosTableAdapter.Fill(this.cddActividad.Sucesos);

            this.reportViewer1.RefreshReport();
        }
    }
}
