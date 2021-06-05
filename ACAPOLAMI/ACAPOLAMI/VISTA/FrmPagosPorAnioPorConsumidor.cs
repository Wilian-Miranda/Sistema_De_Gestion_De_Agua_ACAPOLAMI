using ACAPOLAMI.DAO;
using ACAPOLAMI.MODELO;
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
    public partial class FrmPagosPorAnioPorConsumidor : Form
    {
        public FrmPagosPorAnioPorConsumidor()
        {
            InitializeComponent();
        }
        void CargarConsumidor()
        {
            cbxConsumidores.Items.Clear();
            ClsDConsumidores consumidores = new ClsDConsumidores();
            List<Consumidores> list = consumidores.ConsultarConsumidores();
            foreach (var i in list)
            {
                cbxConsumidores.Items.Add(i.nombresConsumidor);
            }
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

        private void FrmPagosPorAnioPorConsumidor_Load(object sender, EventArgs e)
        {
            CargarConsumidor();
            CargarAnio();

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            String consumidor = cbxConsumidores.SelectedItem.ToString();
            String fecha = Convert.ToString(cbxAnio.SelectedItem);
            //Los primeros 3 valores son anio, mes, dia
            //los ultimos 3 son hora, minuto y segundo
            DateTime fechaD = new DateTime(Convert.ToInt32(fecha), 4, 3, 2, 3, 2);


            pagosAnioConsTableAdapter.Fill(cddPagosPorAnioPorConsumidor.PagosAnioCons, fechaD, consumidor);
            reportViewer1.RefreshReport();
        }
    }
}
