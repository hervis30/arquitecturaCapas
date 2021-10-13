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
    public partial class formulario : System.Web.UI.Page
    {
        CRcitas ONcitas = new CRcitas();
        CEcitas OEcitas = new CEcitas();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

    

        protected void btnconsultarPaciente_Click(object sender, EventArgs e)
        {

        }

        protected void btnconsultarcita_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            OEcitas.Codcita = txtcita.Text;

            ds = ONcitas.consultar_cita(OEcitas);
            if (ds.Tables[0].Rows.Count == 0)
            {
                lblresultado.Text = "Cita no existe";
            }
            else
            {
                txtfecha.Text = ds.Tables[0].Rows[0]["fecha"].ToString();
            }
        }

        protected void btnguardarcita_Click(object sender, EventArgs e)
        {
            OEcitas.Codcita = txtcita.Text;
            OEcitas.Fecha = Convert.ToDateTime(txtfecha.Text);
            OEcitas.Valor = Convert.ToInt32(txtvalor.Text);

            if (ONcitas.guardar_cita(OEcitas))
            {
                lblresultado.Text = "Cita Guardada";
            }
            else
            {
                lblresultado.Text = "Error al guardar cita";
                //asi se hace anular
            }
        }
    }
}