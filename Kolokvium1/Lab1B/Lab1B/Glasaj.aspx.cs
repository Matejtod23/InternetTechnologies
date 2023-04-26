using System;
using System.Web.UI.WebControls;

namespace Lab1B
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListItem pred1 = new ListItem("Интернет Технологии", "Проф. д-р Гоце Арменски");

                ListItem kredit1 = new ListItem();
                kredit1.Text = "6";

                ListItem pred2 = new ListItem("Интернет", "Проф. д-р Ристе Стојанов");

                ListItem kredit2 = new ListItem();
                kredit2.Text = "5.5";

                ListItem pred3 = new ListItem("Дигитална етика", "Проф. д-р Миле Јованов");

                ListItem kredit3 = new ListItem();
                kredit3.Text = "5";

                

                lbPredmeti.Items.Add(pred1);
                lbPredmeti.Items.Add(pred2);
                lbPredmeti.Items.Add (pred3);

                lbKrediti.Items.Add(kredit1);
                lbKrediti.Items.Add(kredit2);
                lbKrediti.Items.Add(kredit3);
            }
        }

        protected void save_Click(object sender, EventArgs e)
        {
            if (lbPredmeti.SelectedItem == null && lbKrediti.SelectedItem == null)
            {
                result.Text = "Селектирајте предмет и кредити";
            }
            else
            {
                Response.Redirect("UspeshnoGlasanje.aspx");
            }
        }

        protected void add_Click(object sender, EventArgs e)
        {
            ListItem predmetItem = new ListItem();
            ListItem kreditItem = new ListItem();
            predmetItem.Text = predmet.Text;
            kreditItem.Text = kredit.Text;
            lbPredmeti.Items.Add(predmetItem);
            lbKrediti.Items.Add(kreditItem);

        }

        protected void lbPredmeti_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblProfesor.Text = lbPredmeti.SelectedItem.Value.ToString();
        }

        protected void remove_Click(object sender, EventArgs e)
        {
            ListItemCollection items = lbPredmeti.Items;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Selected == true)
                {
                    lbPredmeti.Items.RemoveAt(i);
                    lbKrediti.Items.RemoveAt(i);
                }
            }
        }
    }
}