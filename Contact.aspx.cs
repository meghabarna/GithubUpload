using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GitHubTestProject
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ////This is testing and check in branch file to check this.
            string test = TEstThisMethod();
        }
        
        private string TEstThisMethod()
        {
        
        return "This is a testing method";
        }
    }
}
