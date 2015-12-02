using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class More : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int passedId = Convert.ToInt32(Request.QueryString["id"]);
        string name = Request.QueryString["name"];
        string county = Request.QueryString["county"];
        string longitude = Request.QueryString["longitude"];
        string latitude = Request.QueryString["latitude"];
        string fishSpec = Request.QueryString["fishSpec"];
        string specRegs = Request.QueryString["specRegs"];
        string siteWl = Request.QueryString["siteWl"];
        Session["longitude"] = longitude;
        Session["latitude"] = latitude;

        lblName.Text = name;
        lblCouty.Text = county;
        lblFishSpec.Text = fishSpec;
        lblLatitude.Text = latitude;
        lblLongitude.Text = longitude;

        HLCatchTimes.NavigateUrl = specRegs;
        HLAreaInfo.NavigateUrl = siteWl;
        
        

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        int UserId = Convert.ToInt32(Session["id"]);
        int passedId = Convert.ToInt32(Request.QueryString["id"]);
        string name = Request.QueryString["name"];
        string county = Request.QueryString["county"];
        string longitude = Request.QueryString["longitude"];
        string latitude = Request.QueryString["latitude"];
        string fishSpec = Request.QueryString["fishSpec"];
        string specRegs = Request.QueryString["specRegs"];
        string siteWl = Request.QueryString["siteWl"];
        
        ConnectionClass.NewFavorite(name,county, longitude, latitude, UserId,specRegs,siteWl);
    }
}