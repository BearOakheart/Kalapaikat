using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CreateAccount : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCreate_Click(object sender, EventArgs e)
    {
        string name = textLogin.Text;
        string password = textPassword.Text;

        User user = ConnectionClass.NewUser(name,password);

        if (user != null)
        {
            Session["Login"] = user.Login;
            Session["type"] = user.Type;

            Response.Redirect("Default.aspx");
        }
        else
        {
            lblError.Text = "Creation failed";
        }
    }
}