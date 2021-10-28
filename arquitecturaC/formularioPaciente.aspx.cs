using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CEentidad;
using CReglas;
using System.Data;

namespace arquitecturaC
{
    public partial class formularioPaciente : System.Web.UI.Page
    {
        CRpaciente ONpacientes = new CRpaciente();
        CEpaciente OEpacientes = new CEpaciente();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnconsultar_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            OEpacientes.Idpaciente = Convert.ToString(txtidpaciente.Text);
            if (ds.Tables[0].Rows.Count == 0)
            {
                lblrespuesta.Text = "Paciente no existe";
            }
            else
            {
                lblrespuesta.Text = ds.Tables[0].Rows[0]["id_paciente"].ToString();

                txtidpaciente.Text = ds.Tables[0].Rows[0]["id_paciente"].ToString();
                txttipodocumento.Text = ds.Tables[0].Rows[0]["tipo_documento"].ToString();
                txtnompaciente.Text = ds.Tables[0].Rows[0]["nombre_acompañante"].ToString();
                txtdirpaciente.Text = ds.Tables[0].Rows[0]["direccion_paciente"].ToString();
                txttelpaciente.Text = ds.Tables[0].Rows[0]["telefono_paciente"].ToString();
                txtcelpaciente.Text = ds.Tables[0].Rows[0]["celular_paciente"].ToString();
            }
        }

        protected void btnguardar_Click(object sender, EventArgs e)
        {
            OEpacientes.Idpaciente = Convert.ToString(txtidpaciente.Text);
            OEpacientes.Tipodocumento = Convert.ToString(txttipodocumento.Text);
            OEpacientes.Nompaciente = Convert.ToString(txtnompaciente.Text);
            OEpacientes.Dirpaciente = Convert.ToString(txtdirpaciente.Text);
            OEpacientes.Telpaciente = Convert.ToInt32(txttelpaciente.Text);
            OEpacientes.Celpaciente = Convert.ToInt32(txtcelpaciente.Text);

            if (ONpacientes.guardar_paciente(OEpacientes))
            {
                lblrespuesta.Text = "Paciente Guardado";
            }
            else
            {
                lblrespuesta.Text = "Error al guardar el paciente";
            }
        }

        protected void btneliminar_Click(object sender, EventArgs e)
        {
            OEpacientes.Idpaciente = Convert.ToString(txtidpaciente.Text);
            if (ONpacientes.eliminar_paciente(OEpacientes))
            {
                lblrespuesta.Text = "Paciente se ha eliminado correctamente";
            }
            else
            {
                lblrespuesta.Text = "No se pudo eliminar la cita";
            }
        }
    }
}