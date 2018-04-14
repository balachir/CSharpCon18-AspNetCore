using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsApp_NetFramework
{
    public partial class Default : System.Web.UI.Page
    {
        public string Message { get; private set; } = "Hello World. ";

        protected void Page_Load(object sender, EventArgs e)
        {
            Message += $" Server time is { DateTime.Now }";

        }
    }
}