using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEentidad;
using System.Data;
using System.Data.SqlClient;

namespace CDdatos
{
    public class CDpaciente
    {
        CCconexion oconexion = new CCconexion();
        SqlCommand ocmd = new SqlCommand();

        public bool Guardar_Paciente(CEpaciente opaciente)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDhospital");
                ocmd.CommandText = "actualizar_paciente";
                ocmd.Parameters.Add  ("idpaciente", opaciente.Idpaciente);
                ocmd.Parameters.Add  ("@idpaciente", opaciente.Idpaciente);
                ocmd.Parameters.Add  ("@tipodocumento", opaciente.Tipodocumento);
                ocmd.Parameters.Add  ("@nompaciente", opaciente.Nompaciente);
                ocmd.Parameters.Add  ("@dirpaciente", opaciente.Dirpaciente);
                ocmd.Parameters.Add  ("@telpaciente", opaciente.Telpaciente);
                ocmd.Parameters.Add  ("@celpaciente", opaciente.Celpaciente);
                ocmd.Parameters.Add("activo", opaciente.Activo);
           

                ocmd.ExecuteNonQuery();
                return true;
                

              
            }
            catch (Exception err)
            {

                throw new Exception(err.Message); ;
            }
        }
        public bool Eliminar_paciente(CEpaciente opaciente)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDhospital");
                ocmd.CommandText = "eliminar_paciente";
                ocmd.Parameters.Add("@idpaciente", opaciente.Idpaciente);
                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }
        }
        public DataSet consultar_paciente(CEpaciente opaciente)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDhospital");
                ocmd.CommandText = "consultar_paciente";
                ocmd.Parameters.Add("@idpaciente", opaciente.Idpaciente);
                SqlDataAdapter da = new SqlDataAdapter(ocmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception err)
            {

                throw;
            }
        }

    }
}
