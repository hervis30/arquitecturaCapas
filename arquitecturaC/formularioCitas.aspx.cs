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

        protected void btnconsultar_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            OEcitas.Codcita = Convert.ToString(txtcodcita.Text);

            ds = ONcitas.consultar_cita(OEcitas);
            if (ds.Tables[0].Rows.Count == 0)
            {
                lblrespuesta.Text = "Cita no existe";
            }
            else
            {
                
                lblrespuesta.Text = ds.Tables[0].Rows[0]["cod_cita"].ToString();

                //txtcodcita.Text = ds.Tables[0].Rows[0]["fecha"].ToString();
                txtfecha.Text = ds.Tables[0].Rows[0]["fecha"].ToString();
                txthora.Text = ds.Tables[0].Rows[0]["hora"].ToString();
                txtidpaciente.Text = ds.Tables[0].Rows[0]["id_medico"].ToString();
                txtidmedico.Text = ds.Tables[0].Rows[0]["id_medico"].ToString();
                txtvalor.Text = ds.Tables[0].Rows[0]["valor"].ToString();
                txtdiagnostico.Text = ds.Tables[0].Rows[0]["diagnostico"].ToString();

            }
        }

        protected void btnguardar_Click(object sender, EventArgs e)
        {
            OEcitas.Codcita = Convert.ToString(txtcodcita.Text);
            OEcitas.Fecha = Convert.ToDateTime(txtfecha.Text);
            OEcitas.Hora = Convert.ToDateTime(txthora.Text);
            OEcitas.Idpaciente = Convert.ToString(txtidpaciente.Text);
            OEcitas.Idmedico = Convert.ToString(txtidmedico.Text);
            OEcitas.Valor = Convert.ToInt32(txtvalor.Text);
            OEcitas.Diagnostico = Convert.ToString(txtdiagnostico.Text);
            OEcitas.Nomacompañante = Convert.ToString(txtnombreAcompañante);
            

            if (ONcitas.guardar_cita(OEcitas))
            {
                lblrespuesta.Text = "Cita Guardada";
            }
            else
            {
                lblrespuesta.Text = "Error al guardar la cita";
            }
        }

        protected void txteliminar_Click(object sender, EventArgs e)
        {
            OEcitas.Codcita = Convert.ToString(txtcodcita.Text);
            if (ONcitas.eliminar_cita(OEcitas))
            {
                lblrespuesta.Text = "Cita se ha eliminado correctamente";
            }
            else
            {
                lblrespuesta.Text = "No se pudo eliminar la cita";
            }
            
        }
    }
}