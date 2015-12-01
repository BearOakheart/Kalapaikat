using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections.ObjectModel;
using System.Xml;
using FishingSpots;

public partial class FishingSpotsView : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LoadXml();
    }

    private void LoadXml()
    {
        XmlDocument xdoc = new XmlDocument();
        xdoc.Load(Server.MapPath("Xml/fs.xml"));
        ObservableCollection<FishingSpot> fs = new ObservableCollection<FishingSpot>();
        int x = 0;

        foreach (XmlNode node in xdoc.DocumentElement)
        {
            string name = node["name"].InnerText;
            string fish_spec = node["fish_spec"].InnerText;
            string county = node["county"].InnerText;
            string latitude = node["point_y"].InnerText;
            string longitude = node["point_x"].InnerText;

            fs.Add(new FishingSpot(name, county, latitude, longitude, fish_spec, x));
            x++;

            GridView1.DataSource = fs;
            GridView1.DataBind();


        }
    }
}