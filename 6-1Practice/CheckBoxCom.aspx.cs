using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _6_1Practice
{
    public partial class CheckBoxCom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           lb2.Text = Request.Form.Get("rbl_tcx");
        }
    }
}