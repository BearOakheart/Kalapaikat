using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        User user = ConnectionClass.LoginUser(txtLogin.Text, txtPassword.Text);

        if (user != null)
        {
            // tallenna muuttujat sessioon
            Session["Login"] = user.Login;
            Session["type"] = user.Type;
            Session["id"] = user.Id;

            Response.Redirect("Default.aspx");
        }
        else
        {
            lblError.Text = "Login failed";
        }
    }
}