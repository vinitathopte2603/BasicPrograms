using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms
{
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
        /// The nextnode
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
    class Queue
    {
        public QNode front;
        QNode rear;
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
        public void Display()
        {
            QNode temp = front;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.nextnode;
            }
        }

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
        public void Sort(Queue q)
        {
            QNode temp = q.front;
            QNode current = temp.nextnode;
            

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
