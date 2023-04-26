using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aud2
{
    public partial class _Default : Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void PrikaziGrad_Click(object sender, EventArgs e)
        {
            string gradovi = "";
            ListItemCollection items = ListaGradovi.Items;
            Odalecenost.Text = "";
            foreach(ListItem item in items)
            {
                if(item.Selected)
                {
                    gradovi += item.Text + " ";
                    Odalecenost.Text += item.Value + " ";
                }
            }
            SelektiranGrad.Text = gradovi;
        }
    }
}