//-----------------------------------------------------------------------
// <copyright file="Stack.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// user defined data type node
    /// </summary>
   public class StkNode
    {
        /// <summary>
        /// The data
        /// </summary>
        public string data;

        /// <summary>
        /// The next node
        /// </summary>
        public StkNode nextnode;

        /// <summary>
        /// Initializes a new instance of the <see cref="StkNode"/> class.
        /// </summary>
        /// <param name="d">The data.</param>
        public StkNode(string d)
        {
            data = d;
            nextnode = null;
        }
    }

    /// <summary>
    /// perform operations on created stack
    /// </summary>
   public class Stack
    {
        /// <summary>
        /// The top of stack
        /// </summary>
        StkNode top;

        /// <summary>
        /// Pushes the specified new data.
        /// </summary>
        /// <param name="newdata">The new data.</param>
        public void Push(string newdata)
        {
            StkNode newnode = new StkNode(newdata);
            if (top == null)
            {
                top = newnode;
            }
            else
            {
                newnode.data = newdata;
                newnode.nextnode = top;
                top = newnode;
            }
        }

        /// <summary>
        /// Pops an element from stack.
        /// </summary>
        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack Underflow");
            }
            else
            {
                top = top.nextnode;
            }
        }

        /// <summary>
        /// shows which element is at the top in the stack.
        /// </summary>
        /// <returns>the top element</returns>
        public string Peek()
        {
            if (!IsEmpty())
            {
                return top.data;
            }

            return string.Empty;
        }

        /// <summary>
        /// Displays the stack.
        /// </summary>
        public void Display()
        {
            StkNode temp = top;
            while (temp != null)
            {
                Console.Write(temp.data + ", ");
                temp = temp.nextnode;
            }
        }

        /// <summary>
        /// Determines whether this instance is empty.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        private bool IsEmpty()
        {
            return top == null;
        }
    }
}
