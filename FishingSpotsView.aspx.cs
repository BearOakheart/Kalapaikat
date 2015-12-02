﻿using System;
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
        dt.Columns.Add("id", typeof(Int32));
        dt.Columns.Add("specRegs", typeof(string));
        dt.Columns.Add("siteWl", typeof(string));
        dt.Columns.Add("accessOwn", typeof(string));          
        dt.Columns.Add("publicAcc", typeof(String));
        
        

        XmlDocument xdoc = new XmlDocument();

        xdoc.Load(Server.MapPath("Xml/fs.xml"));

        
        //XmlNode b = xdoc.SelectSingleNode("/rows/row");
        int id_ = 0;
        
        foreach (XmlNode node in xdoc.DocumentElement)
        {
            XmlNode a = xdoc.SelectSingleNode("/rows/row");
            string name = node["name"].InnerText;
            string fish_spec = node["fish_spec"].InnerText;

            XmlNode value1 = a.SelectSingleNode("spec_regs");

            string specRegs = value1.Attributes["url"].Value;

            XmlNode value2 = a.SelectSingleNode("site_wl");
            string siteWl = value2.Attributes["url"].Value;
            //Console.WriteLine(valueString);

            string county = node["county"].InnerText;
            string latitude = node["point_y"].InnerText;
            string longitude = node["point_x"].InnerText;


            dt.Rows.Add(name, county, longitude, latitude, fish_spec, id_, specRegs,siteWl);

            id_++;


        }
        //dt.DefaultView.RowFilter = "fishSpec = 'Brown Trout'";

        GridView1.DataSource = dt;
        GridView1.DataBind();

    }
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