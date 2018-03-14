using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            textTitle.Focus();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            cbCategory.ClearSelection();
            textTitle.Text = "";
            textFirstName.Text = "";
            textLastName.Text = "";
            DropDownQuestNum.Text = "N/A";
            textIsbn.Text = "";
        }
    }
}