using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class DqNode
    {
        internal char data;
        internal DqNode nextnode;
        public DqNode(char d)
        {
            data = d;
            nextnode = null;
        }
    }
    class Dequeue
    {
        DqNode front;
        DqNode rear;
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
        private void Display(Dequeue queue)
        {
            DqNode temp = queue.front;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.nextnode;
            }
        }
        private static int count(Dequeue queue)
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
            char first, last;
          
                first =d.RemoveFront(d);
                last = d.RemoveRear(d);
            if (first == last)
            {
                Console.WriteLine("String is palindrome");
            }
            else
            {
                Console.WriteLine("not palindrome");
            }
        }
    }
}
