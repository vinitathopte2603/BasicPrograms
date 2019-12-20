//-----------------------------------------------------------------------
// <copyright file="DqNode.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
//-----------------------------------------------------------------------
// <copyright file="Dequeue.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructures
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// Node class to create a node of class type
    /// </summary>
   public class DqNode
    {
        /// <summary>
        /// The data
        /// </summary>
        public char data;

        /// <summary>
        /// The nextnode
        /// </summary>
        public DqNode nextnode;

        public DqNode(char d)
        {
            this.data = d;
            this.nextnode = null;
        }
    }

    /// <summary>
    /// Class containing methods to perform queue using linked list
    /// </summary>
   public class Dequeue
    {
        /// <summary>
        /// The first node
        /// </summary>
        DqNode front;

        /// <summary>
        /// The last node
        /// </summary>
        DqNode rear;
       
        /// <summary>
        /// Counts the nodes in the queue.
        /// </summary>
        /// <param name="queue">The queue.</param>
        /// <returns>returns the total number of nodes present in the queue</returns>
        public static int Count(Dequeue queue)
        {
            int cnt = 0;
            DqNode temp = queue.front;
            while (temp != null)
            {
                cnt++;
                temp = temp.nextnode;
            }

            return cnt;
        }

        /// <summary>
        /// Checks if the string is palindrome.
        /// </summary>
        public static void CheckPalindrome()
        {
            Console.WriteLine("Enter a string : ");
            string str = Console.ReadLine();
            Dequeue d = new Dequeue();
            char[] arr = str.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
               d.InsertRear(d, arr[i]);
            }

            d.Display(d);
            int count = Dequeue.Count(d);
            int flag = 0;
            while (count > 1)
            {
                count = count - 2;
                if (d.RemoveRear(d) != d.RemoveFront(d))
                {
                    flag = 1;
                    break;
                }
            }
            
            if (flag == 0 && count == 1)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not palindrome");
            }
        }

        /// <summary>
        /// Displays the queue.
        /// </summary>
        /// <param name="queue">The queue.</param>
        private void Display(Dequeue queue)
        {
            DqNode temp = queue.front;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.nextnode;
            }
        }

        /// <summary>
        /// Inserts a node in front of the queue.
        /// </summary>
        /// <param name="queue">The queue.</param>
        /// <param name="newdata">The new data.</param>
        private void InsertFront(Dequeue queue, char newdata)
        {
            DqNode newnode = new DqNode(newdata);
            if (queue.front == null)
            {
                queue.front = newnode;
                queue.rear = newnode;
            }
            else
            {
                newnode.nextnode = queue.front;
                queue.front = newnode;
            }
        }

        /// <summary>
        /// Inserts the node to the end of queue.
        /// </summary>
        /// <param name="queue">The queue.</param>
        /// <param name="newdata">The new data.</param>
        private void InsertRear(Dequeue queue, char newdata)
        {
            DqNode newnode = new DqNode(newdata);
            if (queue.front == null)
            {
                queue.front = newnode;
                queue.rear = newnode;
            }
            else
            {
                queue.rear.nextnode = newnode;
                queue.rear = newnode;
            }
        }

        /// <summary>
        /// Removes the front.
        /// </summary>
        /// <param name="queue">The queue.</param>
        /// <returns>returns the element that is removed from front</returns>
        private char RemoveFront(Dequeue queue)
        {
            DqNode temp = null;
            if (queue.front == null && queue.rear == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                temp = queue.front;
                queue.front = queue.front.nextnode;
            }

            return temp.data;
        }

        /// <summary>
        /// Removes the rear node.
        /// </summary>
        /// <param name="queue">The queue.</param>
        /// <returns>returns the character that is removed</returns>
        private char RemoveRear(Dequeue queue)
        {
            DqNode temp1 = null;
            temp1 = queue.rear;
            if (queue.front == null && queue.rear == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                DqNode temp = queue.front;
                while (temp.nextnode.nextnode != null)
                {
                    temp = temp.nextnode;
                }

                temp.nextnode = null;
                queue.rear = temp;
            }

            return temp1.data;
        }
    }
}
