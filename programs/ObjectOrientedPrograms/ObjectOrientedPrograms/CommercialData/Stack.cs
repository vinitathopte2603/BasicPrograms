using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms
{
    class StkNode
    {
       public string data;
       public StkNode nextnode;
        public StkNode(string d)
        {
            data = d;
            nextnode = null;
        }
    }
    class Stack
    {
        StkNode top;
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
        private bool IsEmpty()
        {
            return top == null;
        }

        public string Peek()
        {
            if (!IsEmpty())
            {
                return top.data;
            }
            return string.Empty;
        }
        public void Display()
        {
            StkNode temp = top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.nextnode;
            }
        }

    }
}
