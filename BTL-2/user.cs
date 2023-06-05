using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_2
{
    public class user
    {
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string repassword { get; set; }

        public user(string username, string email, string password, string repassword)
        {
           
            this.username = username;
            this.email = email;
            this.password = password;
            this.repassword = repassword;
        }
    }
}