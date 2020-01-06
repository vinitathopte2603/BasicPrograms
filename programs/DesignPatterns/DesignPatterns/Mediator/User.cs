//-----------------------------------------------------------------------
// <copyright file="User.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
using System;
using System.Collections.Generic;
using System.Text;

     /// <summary>
     /// abstract method declaration
     /// </summary>
    public abstract class User
    {
        /// <summary>
        /// The mediator
        /// </summary>
        protected IChatMediator mediator;

         /// <summary>
         /// The name
         /// </summary>
         protected string name;

        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        /// <param name="med">The mediator.</param>
        /// <param name="name">The name.</param>
        public User(IChatMediator med, string name)
        {
            this.mediator = med;
            this.name = name;
        }

        /// <summary>
        /// Sends the specified Message.
        /// </summary>
        /// <param name="msg">The Message.</param>
        public abstract void Send(string msg);

        /// <summary>
        /// Receives the specified Message.
        /// </summary>
        /// <param name="msg">The Message.</param>
        public abstract void Receive(string msg);
    }
}
