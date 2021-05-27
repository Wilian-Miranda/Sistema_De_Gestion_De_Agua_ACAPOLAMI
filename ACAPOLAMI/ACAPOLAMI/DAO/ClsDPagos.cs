using ACAPOLAMI.MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACAPOLAMI.DAO
{
    class ClsDPagos
    {
        public void AgregarPago(Pagos pagos)
        {
            try
            {
                using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
                {
                    Pagos pagos1 = new Pagos();
                    pagos1.monto = pagos.monto;
                    pagos1.montoCancelado = pagos.montoCancelado;
                    pagos1.montoCancelado = pagos.montoCancelado;
                    pagos1.impuesto = pagos.impuesto;
                    pagos1.idConsumidor_FK = pagos.idConsumidor_FK;
                    db.Pagos.Add(pagos1);
                    db.SaveChanges();

                    MessageBox.Show("Los datos se han agregado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        public void EliminarPago(int ID)
        {
            try
            {
                using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
                {
                    int Eliminar = Convert.ToInt32(ID);
                    Pagos pg = db.Pagos.Where(x => x.idPago == Eliminar).Select(x => x).FirstOrDefault();
                    pg = db.Pagos.Find(Eliminar);
                    db.Pagos.Remove(pg);
                    db.SaveChanges();

                    MessageBox.Show("Los datos  se han eliminado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Modificarpago(Pagos pag)
        {
            try
            {
                using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
                {
                    int mod = pag.idPago;
                    Pagos pg = db.Pagos.Where(x => x.idPago == mod).Select(x => x).FirstOrDefault();

                    pg.Consumidores.nombresConsumidor = pag.Consumidores.nombresConsumidor;
                    pg.Consumidores.apellidosConsumidor = pag.Consumidores.apellidosConsumidor;
                    pg.monto = pag.monto;
                    pg.montoCancelado = pag.montoCancelado;
                    pg.montoPendiente = pag.montoPendiente;
                    pg.impuesto = pag.impuesto;
                    pg.idEstado_FK = pag.idEstado_FK;
                    pg.fechaPago = pag.fechaPago;

                    db.SaveChanges();
                    MessageBox.Show("Los Datos se Actualizaron ");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public List<String> CargarAnio()
        {
            List<String> listFecha = new List<string>();
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    String ultimaFecha = "";
                    foreach (var k in listFecha)
                    {
                        ultimaFecha = k;
                    }

                    if (ultimaFecha == "2021")
                    {
                        break;

                    }
                    else
                    {
                        if (j == 10)
                        {
                            if (i == 1)
                            {
                                listFecha.Add("2" + (i - 1).ToString() + (j + 10).ToString());
                            }
                            else
                            {
                                listFecha.Add("2" + i.ToString() + j.ToString());
                            }
                        }

                        else
                        {
                            listFecha.Add("20" + i.ToString() + j.ToString());
                        }
                    }
                }
            }
            return listFecha;
        }
    }

}

