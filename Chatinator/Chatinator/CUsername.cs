using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatinator
{
    /// <summary>
    /// This class will be used to match usernames to chat messages.
    /// </summary>
    class CUsername
    {     
        private string user;
        public string setUser
        {
            get { return this.user; }
            set { this.user = value; }
        }
    }
}
