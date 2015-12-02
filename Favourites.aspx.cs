using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Favourites : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        

    }
}


/*
   <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:KalaConnectionString %>" SelectCommand="SELECT * FROM [Favourites] WHERE ([id] = @idNow)">
        <SelectParameters>
		    <asp:SessionParameter name="id" sessionfield="idNow" type="int32" />
	    </SelectParameters>
    </asp:SqlDataSource>
*/
