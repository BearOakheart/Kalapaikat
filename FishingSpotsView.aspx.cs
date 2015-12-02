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
    DataTable dt = new DataTable("FishingSpots");
    ObservableCollection<FishingSpot> fs = new ObservableCollection<FishingSpot>();
    protected void Page_Load(object sender, EventArgs e)
    {
        LoadAndCreateDT();
    }

    public void LoadAndCreateDT()
    {
        DataColumn fishCol = dt.Columns.Add("name", typeof(string));
        dt.Columns.Add("county", typeof(string));
        dt.Columns.Add("longitude", typeof(string));
        dt.Columns.Add("latitude", typeof(string));
        dt.Columns.Add("fishSpec", typeof(string));
        //dt.Columns.Add("id", typeof(Int32));

        

        XmlDocument xdoc = new XmlDocument();
        xdoc.Load(Server.MapPath("Xml/fs.xml"));

        int x = 0;

        foreach (XmlNode node in xdoc.DocumentElement)
        {
            string name = node["name"].InnerText;
            string fish_spec = node["fish_spec"].InnerText;
            string county = node["county"].InnerText;
            string latitude = node["point_y"].InnerText;
            string longitude = node["point_x"].InnerText;
           
            fs.Add(new FishingSpot(name, county, latitude, longitude, fish_spec, x));
                        
            dt.Rows.Add(name, county, longitude, latitude, fish_spec);

            x++;


        }
        //dt.DefaultView.RowFilter = "fishSpec = 'Brown Trout'";

        GridView1.DataSource = dt;
        GridView1.DataBind();

    }

    /*
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        string testi = TextBox1.Text;
        dt.DefaultView.RowFilter = "fishSpec LIKE " + "'*" + testi + "*'" +
                                    "OR " +
                                    "name LIKE " + "'*" + testi + "*'" +
                                    "OR " +
                                    "county LIKE " + "'*" + testi + "*'";

        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    */
    protected void Button1_Click(object sender, EventArgs e)
    {
        string testi = TextBox1.Text;
        dt.DefaultView.RowFilter = "fishSpec LIKE " + "'*" + testi + "*'" +
                                    "OR " +
                                    "name LIKE " + "'*" + testi + "*'" +
                                    "OR " +
                                    "county LIKE " + "'*" + testi + "*'";

        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
}