using ProyectoCiclo3.MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCiclo3.DAO
{
    class ClsDConsumidores
    {

        public void InsertarUsuario(Consumidores consumidores)
        {
            using (ACAPOLAMIEntities db = new ACAPOLAMIEntities())
            {

                Consumidores consumidores1 = new Consumidores();

                consumidores1.nombresConsumidor = consumidores.nombresConsumidor;
                consumidores1.apellidosConsumidor = consumidores.apellidosConsumidor;
                consumidores1.numeroDocumento = consumidores.numeroDocumento;
                consumidores1.telefono = consumidores.telefono;
                consumidores1.correo = consumidores.correo;
                consumidores1.idComunidad_FK = consumidores.idComunidad_FK;
                db.Consumidores.Add(consumidores1);
                db.SaveChanges();

                MessageBox.Show("Los datos se agregaron exitosamente ");
            }
        }
    }
}
