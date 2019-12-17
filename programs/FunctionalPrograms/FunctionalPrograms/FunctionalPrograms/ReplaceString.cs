//-----------------------------------------------------------------------
// <copyright file="ReplaceString.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// replace a word in given string
    /// </summary>
    public class ReplaceString
    {
        /// <summary>
        /// Replaces the string result.
        /// </summary>
        public static void ReplaceStringResult()
        {
                Console.WriteLine("Enter user name");
                string userName = Console.ReadLine();
                Utility.ReplaceString(userName);
        }
    }
}
