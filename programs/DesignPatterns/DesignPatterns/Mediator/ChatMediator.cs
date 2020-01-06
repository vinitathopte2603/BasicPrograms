//-----------------------------------------------------------------------
// <copyright file="ChatMediator.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
using System;
using System.Collections.Generic;
using System.Text;

     /// <summary>
     /// class implementing the interface
     /// </summary>
     /// <seealso cref="DesignPatterns.IChatMediator" />
    public class ChatMediator : IChatMediator
    {
         /// <summary>
         /// The users
         /// </summary>
        private List<User> users;

         /// <summary>
         /// Initializes a new instance of the <see cref="ChatMediator"/> class.
         /// </summary>
        public ChatMediator()
        {
           this.users = new List<User>();
        }

        /// <summary>
        /// Adds the user.
        /// </summary>
        /// <param name="user">The user.</param>
        public void AddUser(User user)
        {
          this.users.Add(user);
        }

         /// <summary>
         /// Sends the message.
         /// </summary>
         /// <param name="msg">The Message.</param>
         /// <param name="user">The user.</param>
        public void SendMessage(string msg, User user)
        {
            foreach (User u in this.users)
            {
                ////message should not be received by the user sending it
                if (u != user)
                {
                    u.Receive(msg);
                }
            }
        }
    }
}
