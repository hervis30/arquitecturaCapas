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
    public class CDcitas
    {
        CCconexion oconexion = new CCconexion();
        SqlCommand ocmd = new SqlCommand();

        public bool Guardar_cita(CEcitas ocitas)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDhospital");
                ocmd.CommandText = "actualizar_cita";
                ocmd.Parameters.Add("@codcita", ocitas.Codcita);
                ocmd.Parameters.Add("@fecha", ocitas.Fecha);
                ocmd.Parameters.Add("@hora", ocitas.Hora);
                ocmd.Parameters.Add("@idpaciente", ocitas.Idpaciente);
                ocmd.Parameters.Add("idmedico", ocitas.Idmedico);
                ocmd.Parameters.Add("@diagnostico", ocitas.Diagnostico);
                ocmd.Parameters.Add("@nomacompañante", ocitas.Nomacompañante);
                ocmd.Parameters.Add("@activo", ocitas.Activo);

                ocmd.ExecuteNonQuery();
                return true;
                }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public bool Eliminar_cita(CEcitas ocitas)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDhospital");
                ocmd.CommandText = "eliminar_cita";
                ocmd.Parameters.Add("@codcita", ocitas.Codcita);
                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }
        }
        public DataSet Consultar_cita(CEcitas ocitas)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDhospital");
                ocmd.CommandText = "consultar_cita";
                ocmd.Parameters.Add("@Codcita", ocitas.Codcita);
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
