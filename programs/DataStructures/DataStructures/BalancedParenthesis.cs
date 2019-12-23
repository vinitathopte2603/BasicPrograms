//-----------------------------------------------------------------------
// <copyright file="BalancedParenthesis.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructures
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// class to take string input to check if parenthesis are balanced.
    /// </summary>
    public class BalancedParenthesis
    {
        /// <summary>
        /// Balances the parenthesis.
        /// </summary>
        public static void BalanceParenthesis()
        {

            Console.WriteLine("Enter an expression : ");
            string expression = Console.ReadLine();
            if (!expression.Contains('[') && !expression.Contains('(') && !expression.Contains('{') && !expression.Contains('}') && !expression.Contains(')') && !expression.Contains(']'))
            {
                Console.WriteLine("given expression is a string of characters only");
            }
            else
            {
                string result = Utility.IsBalanced(expression);
                Console.WriteLine(result);
            }          
        }
    }
}
