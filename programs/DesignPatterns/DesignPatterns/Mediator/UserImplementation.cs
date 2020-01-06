//-----------------------------------------------------------------------
// <copyright file="UserImplementation.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
using System;
using System.Collections.Generic;
using System.Text;

     /// <summary>
     /// implements user interface
     /// </summary>
     /// <seealso cref="DesignPatterns.User" />
    public class UserImplementation : User
    {
         /// <summary>
         /// Initializes a new instance of the <see cref="UserImplementation"/> class.
         /// </summary>
         /// <param name="med">The mediator.</param>
         /// <param name="name">The name.</param>
        public UserImplementation(IChatMediator med, string name) : base(med, name)
        { 
        }

         /// <summary>
         /// Sends the specified Message.
         /// </summary>
         /// <param name="msg">The Message.</param>
        public override void Send(string msg)
        {
            Console.WriteLine(this.name + ": Sending Message=" + msg + "\n");
            mediator.SendMessage(msg, this);
        }

         /// <summary>
         /// Receives the specified Message.
         /// </summary>
         /// <param name="msg">The Message.</param>
        public override void Receive(string msg)
        {
           Console.WriteLine(this.name + ": Received Message:" + msg);
        }
    }
}
