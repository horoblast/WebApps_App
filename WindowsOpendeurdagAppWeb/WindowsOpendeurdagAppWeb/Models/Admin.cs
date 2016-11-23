using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WindowsOpendeurdagAppWeb.Models
{
    public class Admin
    {
        public int AdminId { get; set; }

        public string Username { get; set; }

        /// <summary>
        /// 
        /// add sha256 encoding (salt, hash etc) 
        /// https://blog.mking.io/password-security-best-practices-with-examples-in-csharp/
        /// http://stackoverflow.com/questions/16957492/c-sharp-securely-storing-a-password-locally
        /// http://www.codeproject.com/Articles/425150/Beginners-guide-to-a-secure-way-of-storing-passwor
        /// 
        /// </summary>
        public string Password { get; set; }

    }
}