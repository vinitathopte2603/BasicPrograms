using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms
{
    class StkNode
    {
       public char data;
       public StkNode nextnode;
        public StkNode(char d)
        {
            data = d;
            nextnode = null;
        }
    }
    class Stack<T>
    {
        StkNode top;
        public void Push(char newdata)
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

        public char Peek()
        {
            if (!IsEmpty())
            {
                return top.data;
            }
            return ' ';
        }

    }
}
