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
    public partial class FrmConsumidoresPorComunidad : Form
    {
        public FrmConsumidoresPorComunidad()
        {
            InitializeComponent();
            CargarComunidades();
        }

        void CargarComunidades() {
            cbxComunidades.Items.Clear();
            ClsDComunidad clscomunidad = new ClsDComunidad();
            List<Comunidades> list = clscomunidad.ConsultarComunidades();

            foreach (var i in list) {
                cbxComunidades.Items.Add(i.nombreComunidad);
            }
        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            String comunidad = cbxComunidades.SelectedItem.ToString();
            this.dataTable1TableAdapter.Fill(this.cddConsumidoresPorComunidad.DataTable1, comunidad);
            reportViewer1.RefreshReport();
            
        }

        private void FrmConsumidoresPorComunidad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cddConsumidoresPorComunidad.DataTable1' Puede moverla o quitarla según sea necesario.
            


        }
    }
}
