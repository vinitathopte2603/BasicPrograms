//-----------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructures
{
    using System;
using System.Collections.Generic;
    using System.Collections;
using System.Text;

    /// <summary>
    /// Utility class containing logic 
    /// </summary>
   public class Utility
    {
        /// <summary>
        /// Finding prime numbers from 1 to 1000 and arranging them in two dimensional array
        /// </summary>
        public static void TwoDimArray()
        {
            int[,] arr = new int[10, 25];
            int first = 0, second = 0, third = 0, fourth = 0, fifth = 0, sixth = 0, seventh = 0, eighth = 0, ninth = 0, tenth = 0;
            for (int num = 2; num <= 1000; num++)
            {
                int temp = 0;
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        temp++;
                    }
                }

                if (temp == 0)
                {
                    if (num > 0 && num < 101)
                    {
                        arr[0, first] = num;
                        first++;
                    }

                    if (num > 100 && num < 201)
                    {
                        arr[1, second] = num;
                        second++;
                    }

                    if (num > 200 && num < 301)
                    {
                        arr[2, third] = num;
                        third++;
                    }

                    if (num > 300 && num < 401)
                    {
                        arr[3, fourth] = num;
                        fourth++;
                    }

                    if (num > 400 && num < 501)
                    {
                        arr[4, fifth] = num;
                        fifth++;
                    }

                    if (num > 500 && num < 601)
                    {
                        arr[5, sixth] = num;
                        sixth++;
                    }

                    if (num > 600 && num < 701)
                    {
                        arr[6, seventh] = num;
                        seventh++;
                    }

                    if (num > 700 && num < 801)
                    {
                        arr[7, eighth] = num;
                        eighth++;
                    }

                    if (num > 800 && num < 901)
                    {
                        arr[8, ninth] = num;
                        ninth++;
                    }

                    if (num > 900 && num < 1001)
                    {
                        arr[9, tenth] = num;
                        tenth++;
                    }
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        public static void IsPrimeAnagram()
        {
            List<int> prime = new List<int>();
            List<int>anagram=new List<int>();
            for (int num = 2; num <= 1000; num++)
            {
                int temp = 0;
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % 2 == 0)
                    {
                        temp++;
                    }
                }
                if (temp == 0)
                {
                    prime.Add(num);
                }
            }
            for (int i = 0; i < prime.Count; i++)
            {
                for (int l = i+1; l < prime.Count; l++)
                {
                    if (IsAnagram(prime[i], prime[l]))
                    {
                        Console.WriteLine(prime[i]+" "+prime[l]);
                        anagram.Add(prime[i]);
                    }
                }
            }

        }
        public static bool IsAnagram(int num1,int num2)
        {
            int[] arr1 = Count(num1);
            int[] arr2 = Count(num2);
          
            for (int i = 0; i < 10; i++)
            { 
                if (arr1[i] != arr2[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static int[] Count(int number)
        {
            int n = number;
            int [] arr = new int[10];
            while (n > 0)
            {
                arr[n % 10]++;
                n = n / 10;
            }
            return arr;
        }
        /// <summary>
        /// Determines whether the specified string is palindrome.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns>
        ///   <c>true</c> if the specified string is palindrome; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsPalindrome(string str)
        {
            int no_of_characters = 256;
            int odd = 0;
            int[] count = new int[no_of_characters];
            Array.Fill(count, 0);
            for (int i = 0; i < str.Length; i++)
            {
                count[(int)str[i]]++;
            }

            for (int i = 0; i < no_of_characters; i++)
            {
                if (count[i] == 1)
                {
                    odd++;
                }

                if (odd > 1)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Determines whether the specified expression is balanced.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <returns>returns a string mentioning whether the expression is balanced or not</returns>
        public static string IsBalanced(string expression)
        {
            Stack<char> stk = new Stack<char>();
            char[] arr = expression.ToCharArray();
            for (int i = 0; i < expression.Length; i++)
            {
                char current = arr[i];
                if (current == '[' || current == '(' || current == '{')
                {
                    stk.Push(current);
                }

                if (current == ']' || current == ')' || current == '}')
                {
                    if (stk.Count == 0)
                    {
                        return "Not balanced";
                    }

                    char last = stk.Peek();
                    if (current == ']' || current == ')' || current == '}')
                    {
                        stk.Pop();
                    }
                    else
                    {
                        return "Not Balanced";
                    }
                }
            }

            if (stk.Count == 0)
            {
                return "Balanced";
            }
            else
            {
                return "Not balanced";
            }
        }
    }

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
        public void Insert(int newdata)
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
    }
        class StkNode
    {
       public int data;
       public StkNode nextnode;
        public StkNode(int d)
        {
            data = d;
            nextnode = null;
        }
    }
   public class AnagramStack
    {
        StkNode top;
        public void Push(int newdata)
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
                Console.WriteLine("Stack underflow !");
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
        public int Peek()
        {
            if (!IsEmpty())
            {
                return top.data;
            }
            return -1;
        }
        public void Display()
        {
            StkNode temp = top;
            while (temp != null)
            {
                Console.Write(temp.data+" ");
                temp = temp.nextnode;
            }
        }
        private int Count()
        {
            StkNode temp = top;
            int cnt = 0;
            while (temp != null)
            {
                cnt++;
                temp = temp.nextnode;
            }
            return cnt;
        }
        public void Reverse()
        {
            StkNode previous = null;
            StkNode current = top;
            StkNode next = null;
            while (current != null)
            {
                next = current.nextnode;
                current.nextnode = previous;
                previous = current;
                current = next;
            }
            top = previous;
        }
    }
    class LstNode
    {
       public int data;
       public LstNode nextnode;
        public LstNode(int d)
        {
            data = d;
            nextnode = null;
        }
    }
    class OrderedList
    {
        LstNode head;
        public void InsertFirst(int newdata)
        {
            LstNode newnode = new LstNode(newdata);
            if (head == null)
            {
                head = newnode;
            }
            else
            {
                newnode.nextnode = head;
                head = newnode;
            }
        }
        public void Insertlast(int newdata)
        {
            LstNode newnode = new LstNode(newdata);
            if (head == null)
            {
                InsertFirst(newdata);
            }
            else
            {
                LstNode temp = head;
                while (temp != null)
                {
                    temp = temp.nextnode;
                }
                temp.nextnode = newnode;
            }
        }
        public void InsertAtPosition(int newdata, int pos)
        {
            LstNode newnode = new LstNode(newdata);
            int count = Count();
            if (pos > count && pos < 0)
            {
                Console.WriteLine("Insert valid position");
            }
            else if (count == 1)
            {
                InsertFirst(newdata);
            }
            else if (pos == count)
            {
                Insertlast(newdata);
            }
            else
            {
                LstNode temp = head;
                for (int i = 1; i <= (pos - 2); i++)
                {
                    temp = temp.nextnode;
                }
                newnode.nextnode = temp.nextnode;
                temp.nextnode = newnode;
            }
        }
        public void DeleteFirst()
        {
            if (head == null)
            {
                Console.WriteLine("List empty");
            }
            else
            {
                head = head.nextnode;
            }
        }
        public void DeleteLast()
        {
            if (head == null)
            {
                Console.WriteLine("List empty");
            }
            else
            {
                LstNode temp = head;
                while (temp.nextnode.nextnode != null)
                {
                    temp = temp.nextnode;
                }
                temp.nextnode = null;
            }
        }
        public void DeleteAtPos(int pos)
        {
            int count = Count();
            if (pos > count && pos < 0)
            {
                Console.WriteLine("Enter valid position");
            }
            else if (pos == 1)
            {
                DeleteFirst();
            }
            else if (pos == count)
            {
                DeleteLast();
            }
            else
            {
                LstNode temp1 = head;
                LstNode temp2 = null;
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
            int count = 0;
            LstNode temp = head;
            while (temp != null)
            {
                count++;
                temp = temp.nextnode;
            }
            return count;
        }
        public void Display()
        {
            LstNode temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.nextnode;
            }
        }
        public void Sort()
        {
            LstNode current = head;
            while (current != null)
            {
                LstNode next = current.nextnode;
                while (next != null)
                {
                    if (current.data > next.data)
                    {
                        int temp = next.data;
                        next.data = current.data;
                        current.data = temp;
                    }
                    next = next.nextnode;
                }
                current = current.nextnode;
            }
        }
        public void Search(int searchelement)
        {
            LstNode current = head;
            LstNode current1 = head;
            int count = 0;
            int cnt = 0;
            while (current != null)
            {
                count++;
                if (searchelement.CompareTo(current.data)== 0)
                {
                    Console.WriteLine("Count " + count);
                    if (count == 1)
                    {
                        DeleteFirst();
                    }
                    else if (count == Count())
                    {
                        DeleteLast();
                    }
                    else
                    {
                        DeleteAtPos(count);
                    }
                }

                if (searchelement != current1.data)
                {
                    cnt++;
                }
                current = current.nextnode;
            }
            
            if (cnt == Count())
            {
                InsertFirst(searchelement);
            }
        }
    }
}
