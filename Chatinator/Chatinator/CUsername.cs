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
        //Constructor
        public CUsername()
        {

        }
        string IUser;
        public string Username(string InputUser)
        {
            
            IUser = InputUser;
            return InputUser;
        }

        public string Username()
        {
            return IUser;
        }
    }
}
