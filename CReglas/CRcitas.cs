using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDdatos;
using CEentidad;
using System.Data;
using CDdatos;
using CEentidad;
using System.Data;

namespace CReglas
{
    public class CRcitas
    {
        CDcitas odatcitas = new CDcitas();
        public bool guardar_cita(CEcitas oentcita)
        {
            return odatcitas.Guardar_cita(oentcita);
        }
        public bool eliminar_cita(CEcitas oentcita)
        {
            return odatcitas.Eliminar_cita(oentcita);
        }
        public DataSet consultar_cita(CEcitas oentcita)
        {
            return odatcitas.Consultar_cita(oentcita);
        }
    }
}
