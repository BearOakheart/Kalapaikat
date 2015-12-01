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

                    query = string.Format("SELECT user_type FROM Users WHERE name ='{0}'", login);
                    command.CommandText = query;

                    SqlDataReader reader = command.ExecuteReader();
                    User user = null;

                    while (reader.Read())
                    {
                        string type = reader.GetString(0);

                        user = new User(login, password, type);

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
}