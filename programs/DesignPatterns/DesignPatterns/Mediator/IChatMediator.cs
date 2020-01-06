//-----------------------------------------------------------------------
// <copyright file="IChatMediator.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;

    /// <summary>
    /// method declaration in the interface
    /// </summary>
    public interface IChatMediator
    {
        /// <summary>
        /// Sends the message.
        /// </summary>
        /// <param name="msg">The Message.</param>
        /// <param name="user">The user.</param>
        public void SendMessage(string msg, User user);

        /// <summary>
        /// Adds the user.
        /// </summary>
        /// <param name="user">The user.</param>
        void AddUser(User user);
    }
}
