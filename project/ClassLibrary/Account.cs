using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class Account
    {
        private String userName;
        private String password;

        public Account(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }

        public override bool Equals(object obj)
        {
            return obj is Account account &&
                   userName == account.userName &&
                   password == account.password;
        }

        public override int GetHashCode()
        {
            var hashCode = -514035047;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(userName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(password);
            return hashCode;
        }
    }


}
