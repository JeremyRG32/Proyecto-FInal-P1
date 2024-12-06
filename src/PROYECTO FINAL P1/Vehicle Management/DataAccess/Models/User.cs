using System;
using System.Collections.Generic;

namespace Vehicle_Management.DataAccess.Models;

public partial class User
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Role { get; set; } = null!;

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();

    public bool ValidateUser(string username, string password)
    {
        using (var context = new VehicleManagementDbContext())
        {
            var user = context.Users.SingleOrDefault(u => u.UserName == username);
            if (user == null)
            {
                return false;
            }
            return password == user.Password;
        }
    }
    public bool ValidateAdmin(string username)
    {
        using (var context = new VehicleManagementDbContext())
        {
            var user = context.Users.SingleOrDefault(u => u.UserName == username);
            if (user.Role == "Admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public bool ValidateRegister(string username, string password, string confirmpass)
    {
        if (username.Length < 8 || password.Length < 8 || confirmpass.Length < 8 || password != confirmpass)
        {
            return false;
        }
        else
        {
            return true;
        }
        
    }
    public int RegisterUser(string username, string password)
    {
        using (var context = new VehicleManagementDbContext())
        {
            var newuser = new User
            {
                UserName = username,
                Password = password,
                Role = "Client"
            };  
            context.Users.Add(newuser);
            context.SaveChanges();

            int userid = newuser.UserId;
            return userid;

        }
    }
    public int GetUserIdByUsername(string username)
    {
        using(var context  = new VehicleManagementDbContext())
        {
            var user = context.Users.SingleOrDefault(u => u.UserName == username);
            var userid = user.UserId;
            return userid;
        }
    }
}
