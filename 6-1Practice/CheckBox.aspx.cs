using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _6_1Practice
{
    public partial class CheckBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            string txt = "";
            for (int i = 0; i < cbl_tx.Items.Count; i++)
            {
                if (cbl_tx.Items[i].Selected)
                {
                    txt+= cbl_tx.Items[i].Text + "<br />";
                }
            }
            lb1.Text = txt;
        }
    }
}