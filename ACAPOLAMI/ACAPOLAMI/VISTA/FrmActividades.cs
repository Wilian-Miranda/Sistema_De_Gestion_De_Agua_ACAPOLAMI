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
    public partial class FrmActividades : Form
    {
        ClsDSucesos sucesos = new ClsDSucesos();
        public FrmActividades()
        {
            InitializeComponent();
        }

        private void ConfigurarListView()
        {
            var listaSucesos = lstActividades;
            listaSucesos.Columns.Clear();
            listaSucesos.Items.Clear();
            listaSucesos.View = View.Details;
            listaSucesos.GridLines = false;
            listaSucesos.FullRowSelect = true;
            listaSucesos.Scrollable = true;
            listaSucesos.HideSelection = false;

            listaSucesos.Columns.Add("Id", 0, HorizontalAlignment.Left);
            listaSucesos.Columns.Add("Fecha", 150, HorizontalAlignment.Left);
            listaSucesos.Columns.Add("Tipo suceso", 150, HorizontalAlignment.Left);
            listaSucesos.Columns.Add("Descripcion", 1250, HorizontalAlignment.Left);
        }

        private void CargarSucesos(string id, DateTime fecha, string tipo, string descripcion)
        {
            try
            {
                if (lstActividades.Items.Count == 0)
                {
                    ListViewItem item = new ListViewItem();
                    item = lstActividades.Items.Add(id);
                    item.SubItems.Add(fecha.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(tipo);
                    item.SubItems.Add(descripcion);
                }

                else
                {
                    for (int x = 0; x < lstActividades.Items.Count; x++)
                    {
                        if (lstActividades.Items[x].Text.Trim() == id.Trim())
                        {
                            return;
                        }
                    }
                    ListViewItem item = new ListViewItem();
                    item = lstActividades.Items.Add(id);
                    item.SubItems.Add(fecha.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(tipo);
                    item.SubItems.Add(descripcion);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tienes el siguiene problema: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CargarListaSucesos()
        {
            var listaSucesos = sucesos.CargarSucesos();
            foreach (var suceso in listaSucesos)
            {
                CargarSucesos(suceso.idSuceso.ToString(), (DateTime)suceso.fechaSuceso, suceso.tipoSuceso, suceso.descripcion);
            }
        }
    }
}
