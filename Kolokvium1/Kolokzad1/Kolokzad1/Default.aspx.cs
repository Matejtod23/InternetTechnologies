using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Kolokzad1
{
    public partial class _Default : Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void lstZanrovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewState["cenaV"] = "0";
            if (lstZanrovi.SelectedIndex == 0)
            {
                box1.Text = "Forest Gump";
                ViewState["box1"] = "150";
                box2.Text = "Good will hunting";
                ViewState["box2"] = "130";
                box3.Text = "A beautiful mind";
                ViewState["box3"] = "100";
            }
            else if (lstZanrovi.SelectedIndex == 1)
            {
                box1.Text = "Keeping up with the Joneses";
                ViewState["box1"] = "120";
                box2.Text = "Masterminds";
                ViewState["box2"] = "170";
                box3.Text = "Ted2";
                ViewState["box3"] = "180";
            }
            else if (lstZanrovi.SelectedIndex == 2)
            {
                box1.Text = "Batman and Superman 3D";
                ViewState["box1"] = "350";
                box2.Text = "Deadpool 3D";
                ViewState["box2"] = "300";
                box3.Text = "The accountant";
                ViewState["box3"] = "200";
            }
        }

        protected void najava_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            

        }

        protected void txtKolichina1_TextChanged(object sender, EventArgs e)
        {
            if (box1.Checked)
            {
                int curr = Convert.ToInt32(ViewState["cenaV"].ToString());
                int value = (Convert.ToInt32(txtKolichina1.Text) * Convert.ToInt32(ViewState["box1"].ToString()));
                value += curr;
                ViewState["cenaV"] = value;
            }
        }

        protected void txtKolichina2_TextChanged(object sender, EventArgs e)
        {
            if(box2.Checked){
                int curr = Convert.ToInt32(ViewState["cenaV"].ToString());
                int value = (Convert.ToInt32(txtKolichina2.Text) * Convert.ToInt32(ViewState["box2"].ToString()));
                value += curr;
                ViewState["cenaV"] = value;
            }
        }

        protected void buy_Click(object sender, EventArgs e)
        {
            cena.Text = ViewState["cenaV"].ToString();
        }

        protected void txtKolichina3_TextChanged(object sender, EventArgs e)
        {
            if (box3.Checked)
            {
                int curr = Convert.ToInt32(ViewState["cenaV"].ToString());
                int value = (Convert.ToInt32(txtKolichina3.Text) * Convert.ToInt32(ViewState["box3"].ToString()));
                value += curr;
                ViewState["cenaV"] = value;
            }
        }
    }
}