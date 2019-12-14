namespace DataStructures
{
    using System;
using System.Collections.Generic;
using System.Text;


   public class QNode
    {
       public int data;
       public QNode nextnode;
        public QNode(int d)
        {
            data = d;
            nextnode = null;
        }
    }

   public class Queue
    {
        QNode front;
        QNode rear;
        private static void Insert(Queue queue, int newdata)
        {
            QNode newnode = new QNode(newdata);
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
        private static void Remove(Queue queue, int newdata)
        {
            if (queue.front == null && queue.rear == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                queue.front = queue.front.nextnode;
            }
         
        }
        private static void Display(Queue queue)
        {
            QNode temp = queue.front;
            while (temp != null)
            {
                Console.Write(temp.data+" ");
                temp = temp.nextnode;
            }
        }
        public static void CashCounter()
        {
            Queue q = new Queue();
            int choice;
            do
            {
                Console.WriteLine("\n 1 : Deposite \n 2 : Withdraw \n 3 : Exit");
                Console.WriteLine("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Insert amount to be deposited : ");
                        int depo_amt = Convert.ToInt32(Console.ReadLine());
                        Queue.Insert(q, depo_amt);
                        Queue.Display(q);
                        break;
                    case 2:
                        Console.WriteLine("Insert amount to be withdrawn : ");
                        int wthdrw_amt = Convert.ToInt32(Console.ReadLine());
                        Queue.Remove(q, wthdrw_amt);
                        Queue.Display(q);
                        break;
                    case 3:
                        Console.WriteLine("Enter valid choice ! ");
                        break;
                }
                
            }
            while (choice < 4);
        }
    }
}
