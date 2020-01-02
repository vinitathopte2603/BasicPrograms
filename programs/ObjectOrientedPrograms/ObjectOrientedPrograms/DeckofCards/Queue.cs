//-----------------------------------------------------------------------
// <copyright file="Queue.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// class to create node
    /// </summary>
    public class QNode
    {
        /// <summary>
        /// The data
        /// </summary>
        public string data;

        /// <summary>
        /// The next node
        /// </summary>
        public QNode nextnode;

        /// <summary>
        /// Initializes a new instance of the <see cref="QNode"/> class.
        /// </summary>
        /// <param name="d">The data.</param>
        public QNode(string d)
        {
            data = d;
            nextnode = null;
        }
    }

    /// <summary>
    /// class to perform operations on generated queue
    /// </summary>
   public class Queue
    {
        /// <summary>
        /// The front of queue
        /// </summary>
        public QNode front;

        /// <summary>
        /// The rear of queue
        /// </summary>
        public QNode rear;

        /// <summary>
        /// Inserts the specified new data.
        /// </summary>
        /// <param name="newdata">The new data.</param>
        public void Insert(string newdata)
        {
            QNode newnode = new QNode(newdata);
            if (front == null)
            {
                front = newnode;
                rear = newnode;
            }
            else
            {
                rear.nextnode = newnode;
                rear = newnode;
            }
        }

        /// <summary>
        /// Removes a node from front of the list
        /// </summary>
        public void Remove()
        {
            if (front == null && rear == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                front = front.nextnode;
            }

        }

        /// <summary>
        /// Displays the queue
        /// </summary>
        public void Display()
        {
            QNode temp = front;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.nextnode;
            }
        }

        /// <summary>
        /// Counts the elements
        /// </summary>
        /// <returns>the number of elements</returns>
        public int Count()
        {
            QNode temp = front;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.nextnode;
            }

            return count;
        }

        /// <summary>
        /// Sorts the specified queue.
        /// </summary>
        /// <param name="q">The queue.</param>
        public void Sort(Queue q)
        {
            QNode current = q.front;
            while (current != null)
            {
                QNode next = current.nextnode;
                while (next != null)
                {
                    if (current.data.CompareTo(next.data) > 0)
                    {
                        string tempstr = next.data;
                        next.data = current.data;
                        current.data = tempstr;
                    }

                    next = next.nextnode;
                }

                current = current.nextnode;
            }
        }
    }
}
