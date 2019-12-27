using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms
{
    class Node
    {
       public object data;
       public Node nextnode;
        public Node(object d)
        {
            data = d;
            nextnode = null;
        }
    }
    class LinkedList<T>
    {
        Node head;
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

        public void DeleteLast()
        {
            Node temp = head;
            while (temp.nextnode.nextnode != null)
            {
                temp = temp.nextnode;
            }
            temp.nextnode = null;
        }

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
