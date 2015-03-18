using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tramverdeelsysteem.Classes
{
    public class User
    {
        private int userid;
        private string role;
        private string username;
        private string password;

        public int UserID { get { return userid; } }
        public string Role { get { return role; } }
        public string Username { get { return username; } }
        public string Password { get { return password; } }

        public User(int userid, string role, string username, string password)
        {
            this.userid = userid;
            this.role = role;
            this.username = username;
            this.password = password;
        }
    }
}
