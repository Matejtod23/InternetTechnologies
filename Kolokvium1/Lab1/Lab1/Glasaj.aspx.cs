using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbPredmeti_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblProfesor.Text = lbPredmeti.SelectedItem.Value;
        }

        protected void save_Click(object sender, EventArgs e)
        {
            if(lbPredmeti.SelectedItem != null && lbKrediti.SelectedItem != null)
            {
                Response.Redirect("UspesnoGlasanje.aspx");
            }
            else
            {
                result.Text = "Потребно е да се изберат вредности од двете листи";
            }
        }
    }
}