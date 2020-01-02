//-----------------------------------------------------------------------
// <copyright file="Linkedlist.cs" Author="Vinita Thopte" company="Bridgelabz">
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
    public class Node
    {
        /// <summary>
        /// The data
        /// </summary>
        public object data;

        /// <summary>
        /// The next node
        /// </summary>
        public Node nextnode;

        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// </summary>
        /// <param name="d">The data.</param>
        public Node(object d)
        {
            this.data = d;
            this.nextnode = null;
        }
    }

    /// <summary>
    /// perform various operations on created linkedlist
    /// </summary>
    /// <typeparam name="T">data type of the list</typeparam>
    public class Linkedlist<T>
    {
        /// <summary>
        /// The head
        /// </summary>
        public Node head;

        /// <summary>
        /// Inserts the specified new data.
        /// </summary>
        /// <param name="newdata">The new data.</param>
        public void Insert(object newdata)
        {
            Node newnode = new Node(newdata);
            Node temp = head;
            if (head == null)
            {
                head = newnode;
            }
            else
            {
                while (temp != null)
                {
                    temp.nextnode = newnode;
                }
            }
        }

        /// <summary>
        /// Deletes the last node.
        /// </summary>
        public void DeleteLast()
        {
            Node temp = head;
            while (temp.nextnode.nextnode != null)
            {
                temp = temp.nextnode;
            }

            temp.nextnode = null;
        }

        /// <summary>
        /// Deletes the first node.
        /// </summary>
        public void DeleteFirst()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                head = head.nextnode;
            }
        }

        /// <summary>
        /// Deletes the node at given position.
        /// </summary>
        /// <param name="pos">The position.</param>
        public void DeleteAtPosition(int pos)
        {
            Node temp1 = head;
            Node temp2 = null;
            int count = Count();
            if (pos > count || pos < 1)
            {
                Console.WriteLine("Enter valid position");
            }
            else if (pos == count)
            {
                DeleteLast();
            }
            else if (pos == 1)
            {
                DeleteFirst();
            }
            else
            {
                for (int i = 1; i <= (pos - 2); i++) 
                {
                    temp1 = temp1.nextnode;
                }

                temp2 = temp1.nextnode;
                temp1.nextnode = temp2.nextnode;
            }
        }

        /// <summary>
        /// Counts the elements in linked list.
        /// </summary>
        /// <returns>number of elements in the list</returns>
        public int Count()
        {
            Node temp = head;
            int cnt = 0;
            while (temp != null)
            {
                cnt++;
                temp = temp.nextnode;
            }

            return cnt;
        }

        /// <summary>
        /// Displays the elements in list.
        /// </summary>
        public void Display()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.nextnode;
            }
        }
    }
}
