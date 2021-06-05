using ACAPOLAMI.DAO;
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
    public partial class FrmGPagosPorAnio : Form
    {
        public FrmGPagosPorAnio()
        {
            InitializeComponent();
        }
        void CargarAnio()
        {
            cbxAnio.Items.Clear();
            List<String> fechas = new ClsDPagos().CargarAnio();

            foreach (var i in fechas)
            {
                cbxAnio.Items.Add(i.ToString());
            }
        }
        private void FrmGPagosPorAnio_Load(object sender, EventArgs e)
        {
            CargarAnio();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            String fecha = Convert.ToString(cbxAnio.SelectedItem);
            //Los primeros 3 valores son anio, mes, dia
            //los ultimos 3 son hora, minuto y segundo
            DateTime fechaD = new DateTime(Convert.ToInt32(fecha), 1, 1, 1, 1, 1);

            gPagosAnioTableAdapter.Fill(cddGPagosPorAnio.GPagosAnio, fechaD);
            reportViewer1.RefreshReport();
            //try {
            //    
            //}
            //catch (Exception ex) {
            //    MessageBox.Show("Error" + ex.ToString()) ;
            //}

        }
    }
}
