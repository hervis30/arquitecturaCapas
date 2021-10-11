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
    public class CDmedico
    {
        CCconexion oconexion = new CCconexion();
        SqlCommand ocmd = new SqlCommand();

        public bool Guardar_medico(CEmedico omedico)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDhospital");
                ocmd.CommandText = "actualizar_medico";
                ocmd.Parameters.Add("@idmedico", omedico.Idmedico);
                ocmd.Parameters.Add("@nomedico", omedico.Nomedico);
                ocmd.Parameters.Add("@especialidad", omedico.Especialidad);
                ocmd.Parameters.Add("@telmedico", omedico.Telmedico);
                ocmd.Parameters.Add("@activo", omedico.Activo);

                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }
        public bool anula_medico(CEmedico omedico)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDhospital");
                ocmd.CommandText = "anula_medico";
                ocmd.Parameters.Add("@idmedico", omedico.Idmedico);
                ocmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }
        }
        public DataSet Consultar_medico(CEmedico omedico)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDhospital");
                ocmd.CommandText = "Consultar_medico";
                ocmd.Parameters.Add("@idmedico", omedico.Idmedico);
                SqlDataAdapter da = new SqlDataAdapter(ocmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
