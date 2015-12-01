using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for User
/// </summary>
public class User
{
    public int Id { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public string Type { get; set; }

    public User(int id, string login, string password, string type)
    {
        Id = id;
        Login = login;
        Password = password;
        Type = type;
    }

    public User(string login, string password, string type)
    {
        Login = login;
        Password = password;
        Type = type;
    }

}