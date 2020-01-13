using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoConnect
{
    [Serializable]
    public class User
    {
        private string userNume;
        public string UserName
        {
            get { return userNume; }
            set { userNume = value; }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

    }
}
