using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aud2
{
    public partial class Zadaca2Converter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<ListItem> items = new List<ListItem>();
            ListItem item1 = new ListItem("Evro", "61");
            ListItem item2 = new ListItem("Dolar", "55");

            items.Add(item1);
            items.Add(item2);

            ListaValuta.DataSource = items;

            ListaValuta.DataBind();
        }

        protected void DodadiValuta_Click(object sender, EventArgs e)
        {
            ListItem item = new ListItem(ImeValuta.Text, VrednostValuta.Text);
            ImeValuta.Text = "";
            VrednostValuta.Text = "";

            ListaValuta.Items.Add(item);
            BrojValuti.Text = ListaValuta.Items.Count.ToString();

        }

        protected void IzbrisiValuta_Click(object sender, EventArgs e)
        {
            if(ListaValuta.SelectedIndex != -1)
            {
                ListaValuta.Items.Remove(ListaValuta.SelectedItem);
                BrojValuti.Text = ListaValuta.Items.Count.ToString();
            }
            

        }

        protected void ListaValuta_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(ListaValuta.SelectedItem.Value);
            int pari = Convert.ToInt32(Vrednost.Text);

            status.Text = Convert.ToString(value * pari);

        }

       
    }

}