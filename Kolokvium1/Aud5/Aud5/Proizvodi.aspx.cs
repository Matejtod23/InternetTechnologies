using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aud5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                naslov.Text = Request.QueryString.Get("name");

                string[] s1 = {
                    "Modern Operating systems by Andew S.",
                    "Advanced Programming in the UNIX Environment",
                    "The Mythical Man-moth"
                };

                string[] s1_c =
                {
                    "45", "25", "20"
                };

                string[] s2 =
                {
                    "Original by Dan Brown",
                    "The Hobbit",
                    "Harry Potter and the Philosophers"
                };

                string[] s2_c =
                {
                    "35", "10", "20"
                };

                switch (Convert.ToInt32(Request.QueryString.Get("catId")))
                {
                    case 0:
                        naslovi.DataSource = s1;
                        ceni.DataSource = s1_c;
                        break;
                    case 1:
                        naslovi.DataSource = s2;
                        ceni.DataSource = s2_c;
                        break;
                }
                naslovi.DataBind();
                ceni.DataBind();
            }
        }

        protected void naslovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ViewState["total"] == null)
            {
                ViewState["total"] = 1;
            }
            else
            {
                ViewState["total"] = Convert.ToInt32(ViewState["total"]) + 1;
            }

            total.Text = ViewState["total"].ToString();

            ceni.SelectedIndex = naslovi.SelectedIndex;
        }

        protected void add_Click(object sender, EventArgs e)
        {
            ArrayList lista;

            if (Session["cart"] == null)
            {
                lista = new ArrayList();
            }
            else
            {
                lista = (ArrayList)Session["cart"];
            }

            lista.Add(new ListItem(naslovi.SelectedItem.Text, ceni.SelectedItem.Text));

            koshnicka.DataTextField = "Text";
            koshnicka.DataValueField = "Value";

            koshnicka.DataSource = lista;
            koshnicka.DataBind();

            Session["cart"] = lista;
        }

        protected void kupi_Click(object sender, EventArgs e)
        {
            Response.Redirect("Plakjanje.aspx");
        }
    }
}