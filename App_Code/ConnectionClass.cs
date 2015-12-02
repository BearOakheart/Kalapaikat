using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;


/// <summary>
/// Summary description for ConnectionClass
/// </summary>
public static class ConnectionClass
{
    private static SqlConnection conn;
    private static SqlCommand command;
    private static SqlCommand commandtwo;

    static ConnectionClass()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["KalaConnectionString"].ToString();
        conn = new SqlConnection(connectionString);
        command = new SqlCommand("",conn);
    }

 

    public static User LoginUser(String login, String password)
    {
        string query = string.Format("SELECT COUNT(*) FROM Kala.dbo.Users WHERE name ='{0}'", login);
        command.CommandText = query;

        // varmistus että connection on suljettu
        if (conn != null)
        {
            conn.Close();
        }

        // yritetään avata yhteys
        try
        {
            conn.Open();
            int amoutOfUsers = (int) command.ExecuteScalar();

            if (amoutOfUsers == 1)
            {
                // Käyttäjä on olemassa tarkistetaan toimiiko salasana
                query = string.Format("SELECT password FROM Users WHERE name ='{0}'", login);
                command.CommandText = query;
                string dbPassword = command.ExecuteScalar().ToString();

                if (dbPassword == password)
                {
                    // Salasanat täsmää 
                    // Hae loput käyttäjän tidot databasesta.

                    query = string.Format("SELECT user_type,id FROM Users WHERE name ='{0}'", login);
                    command.CommandText = query;

                    SqlDataReader reader = command.ExecuteReader();



                    User user = null;

                    while (reader.Read())
                    {
                        string type = reader.GetString(0);
                        int id = reader.GetInt32(1);

                        user = new User(id,login, password, type);

                    }
                    return user;

                }
                else
                {
                    // Salasanat eivät täsmää
                    return null;

                }
            }
            else
            {
                //käyttäjä on jo kirjautunut

                return null;
            }


        }
        catch (Exception)
        {
            conn.Close();
            throw;
        }
        
       

    }
    public static User NewUser(String login, String password)
    {
        string query1 = string.Format("SELECT COUNT(*) FROM Kala.dbo.Users WHERE name ='{0}'", login);
        command.CommandText = query1;

        if (conn != null)
        {
            conn.Close();           
        }

      
        try
        {
           conn.Open();
           int amoutOfUsers = (int)command.ExecuteScalar();
           

            if (amoutOfUsers == 0)
            {

                
                string query = string.Format("INSERT INTO Kala.dbo.Users VALUES ('{0}', '{1}', 'user')", login, password);

                command.CommandText = query;
                command.ExecuteScalar();

                string query2 = string.Format("SELECT id FROM Kala.dbo.Users WHERE name ='{0}'",login);
                command.CommandText = query2;
                int id_ = (int)command.ExecuteScalar(); 


                User user = new User(id_,login, password, "user");
                return user;
            }
            else
            {
                return null;
            }
        }

        catch (Exception)
        {
            conn.Close();
            return null;
            throw;
        }
    }

    public static string NewFavorite(string name,string county, string point_x, string point_y, int UserId,string specRegs, string siteWl)
    {
        string query = string.Format("INSERT INTO Kala.dbo.Favourites (name,county,point_x,point_y,UserId,spec_regs,site_wl) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", name,county,point_x,point_y, UserId,specRegs,siteWl);

        
        if (conn != null)
        {
            conn.Close();
        }
    
            conn.Open();
            command.CommandText = query;

            command.ExecuteScalar();
            conn.Close();
            return "New favourite added";     
    }
}