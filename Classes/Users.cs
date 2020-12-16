using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace StocksAndFinance
{
    public static class Users
    {
        public static User currentUser = null;
        public static List<User> users = DbHandler.SelectAllUsers();

        public static bool Login(string email, string password)
        {
            Debug.WriteLine(email + "  " + password);
            foreach (var user in users)
            {
                if (user.Email == email && user.Password == password)
                {
                    currentUser = user;
                    return true;
                }   
            }
            return false;
        }

        public static bool RegisterNewUser(string email, string fName, string lName, string password, char type)
        {
            if(DbHandler.InsertNewUser(email, fName, lName, password, type))
            {
                User newUser = DbHandler.SelectUser(email);
                users.Add(newUser);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckForExsistingUser(string email)
        {
            foreach (var user in users)
            {
                if (user.Email == email)
                    return true;
            }
            return false;
        }
    }
}