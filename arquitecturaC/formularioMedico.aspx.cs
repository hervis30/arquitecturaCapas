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
    public partial class formularioMedico : System.Web.UI.Page
    {
        CRmedico ONmedico = new CRmedico();
        CEmedico OEmedico = new CEmedico();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnconsultar_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            OEmedico.Idmedico = Convert.ToString(txtidmedico.Text);

            ds = ONmedico.consultar_medico(OEmedico);
            if (ds.Tables[0].Rows.Count == 0)
            {
                lblrespuesta.Text = "Medico no encontrado";
            }
            else
            {
                lblrespuesta.Text = ds.Tables[0].Rows[0]["id_medico"].ToString();

                txtidmedico.Text = ds.Tables[0].Rows[0]["id_medico"].ToString();
                txtnomedico.Text = ds.Tables[0].Rows[0]["nomedico"].ToString();
                txtespecialidad.Text = ds.Tables[0].Rows[0]["especialidad"].ToString();
                txttelmedico.Text = ds.Tables[0].Rows[0]["telmedico"].ToString();
            }
        }

        protected void btnguardar_Click(object sender, EventArgs e)
        {
            OEmedico.Idmedico = Convert.ToString(txtidmedico.Text);
            OEmedico.Nomedico = Convert.ToString(txtnomedico.Text);
            OEmedico.Especialidad = Convert.ToString(txtespecialidad.Text);
            OEmedico.Telmedico = Convert.ToString(txttelmedico.Text);

            if (ONmedico.guardar_medico(OEmedico))
            {
                lblrespuesta.Text = "Medico guardado";
            }
            else
            {
                lblrespuesta.Text = "Error al guardar medico";
            }
        }

        protected void btneliminar_Click(object sender, EventArgs e)
        {
            OEmedico.Idmedico = Convert.ToString(txtidmedico.Text);
            if (ONmedico.eliminar_medico(OEmedico))
            {
                lblrespuesta.Text = "Medico se ha eliminado correctamente";
            }
            else
            {
                lblrespuesta.Text = "No se pudo eliminar al medico";
            }
        }
    }
}