using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEentidad;
using CDdatos;
using System.Data;

namespace CReglas
{
    public class CRmedico
    {
        CDmedico odatmedico = new CDmedico();
        public bool guardar_medico(CEmedico oentmedico)
        {
            return odatmedico.Guardar_medico(oentmedico);
        }
        public bool eliminar_medico(CEmedico oentmedico)
        {
            return odatmedico.Eliminar_medico(oentmedico);
        }
        public DataSet consultar_medico(CEmedico oentmedico)
        {
            return odatmedico.Consultar_medico(oentmedico);
        }
    }
}
