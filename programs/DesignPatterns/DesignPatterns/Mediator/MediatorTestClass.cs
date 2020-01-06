//-----------------------------------------------------------------------
// <copyright file="MediatorTestClass.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;

    /// <summary>
    /// class to test the mediator design pattern
    /// </summary>
   public class MediatorTestClass
    {
        /// <summary>
        /// Tests the mediator design pattern
        /// </summary>
        public static void TestMediator()
        {
            IChatMediator mediator = new ChatMediator();
            User user1 = new UserImplementation(mediator, "Pooja");
            User user2 = new UserImplementation(mediator, "Ankit");
            User user3 = new UserImplementation(mediator, "Prasad");
            User user4 = new UserImplementation(mediator, "Arti");

            mediator.AddUser(user1);
            mediator.AddUser(user2);
            mediator.AddUser(user3);
            mediator.AddUser(user4);

            user1.Send("Hi all");
            Console.WriteLine();
            user2.Receive("gm");
        }
    }
}
