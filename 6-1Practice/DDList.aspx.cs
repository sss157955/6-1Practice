using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _6_1Practice {
    public partial class DDList : System.Web.UI.Page {
        string[] place = new string[] { "基隆", "台北", "新北", "苗栗", "台中", "南投" };
        protected void Page_Load(object sender, EventArgs e) {
            ddl_Area.Items.Clear();
            ddl_Area.Items.Add("北區");
            ddl_Area.Items.Add("中區");
            if (ViewState["place"] != null)
            {
                int index = int.Parse(ViewState["place"].ToString());
                ddl_Area.Items[index].Selected = true;
            }
            else
            {
                ddl_Area.Items[0].Selected = true;
                for (int i = 0; i < 3; i++)
                {
                    ddl_Place.Items.Add(place[i]);
                }
            }
        }

        protected void ddl_Area_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddl_Place.Items.Clear();
            if (ddl_Area.Items[0].Selected)
            {
                ddl_Area.Items[0].Selected = false;
                ddl_Area.Items[1].Selected = true;
                for (int i = 3; i < 6; i++)
                {
                    ddl_Place.Items.Add(place[i]);
                }
            }
            else
            {
                ddl_Area.Items[0].Selected = true;
                ddl_Area.Items[1].Selected = false;
                for (int i = 0; i < 3; i++)
                {
                    ddl_Place.Items.Add(place[i]);
                }
            }
            ViewState["place"] = ddl_Area.SelectedIndex;
        }
    }
}