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

        /// <summary>
        /// Receives the username and stores it in IUser.
        /// </summary>
        public void Username(string InputUser)//used by Login.cs to get input.
        {          
            IUser = InputUser;//saves the username.           
        }

        //!a new instanc is getting created in Chat.cs and IUser is getting reset to null.
        /// <summary>
        /// Gives the username to Chat.cs
        /// </summary>
        public string Username()//used from Chat.cs
        {
            return IUser;//returns the username 
        }
    }
}
