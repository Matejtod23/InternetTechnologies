using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aud5
{
    public partial class Plakjanje : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                koshnicka.DataTextField = "Text";
                koshnicka.DataValueField = "Value";
                koshnicka.DataSource = (ArrayList)Session["cart"];
                koshnicka.DataBind();

                int totalValue = 0;

                foreach(ListItem li in koshnicka.Items)
                {
                    totalValue += Convert.ToInt32(li.Value);
                }

                kupi.Text = "Купи ($ " + totalValue.ToString() + ")";
            }
        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("Proizvodi.aspx");
        }
    }
}