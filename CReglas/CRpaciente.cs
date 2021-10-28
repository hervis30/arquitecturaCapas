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
    public class CRpaciente
    {
        CDpaciente odatpaciente = new CDpaciente();

        public bool guardar_paciente(CEpaciente oentpaciente)
        {
            return odatpaciente.Guardar_Paciente(oentpaciente);
        }
        public bool eliminar_paciente(CEpaciente oentpaciente)
        {
            return odatpaciente.Eliminar_paciente(oentpaciente);
        }
        public DataSet consultar_paciente(CEpaciente oentpaciente)
        {
            return odatpaciente.consultar_paciente(oentpaciente);
        }
    }
}
