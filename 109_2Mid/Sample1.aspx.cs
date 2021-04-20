using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _109_2Mid {
    public partial class Sample1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
          
                if(CheckBox1.Checked == true)
                {
                    CheckBox2.Visible = false;
                    CheckBox3.Enabled = false;
                }
            

        }
    }
}