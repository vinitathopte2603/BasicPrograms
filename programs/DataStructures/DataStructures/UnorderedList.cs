namespace DataStructures
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    /// <summary>
    /// creating a linked list and reading data from a file to store it in linked list
    /// </summary>
    public class Node
    {
        public string data;
        public Node nextnode;
        public Node(string d)
        {
            data = d;
            nextnode = null;
        }
    }
    class UnorderedList
    {
        Node head;
        private static UnorderedList InsertFirst(UnorderedList list, string newdata)
        {
            Node newnode = new Node(newdata);
            if (list.head == null)
            {
                list.head = newnode;
            }
            else
            {
                newnode.nextnode = list.head;
                list.head = newnode;
            }
            return list;
        }
        private static UnorderedList InsertLast(UnorderedList list, string newdata)
        {
            Node newnode = new Node(newdata);
            Node temp = list.head;
            while (temp.nextnode != null)
            {
                temp = temp.nextnode;
            }
            temp.nextnode = newnode;
            return list;
        }
        private static UnorderedList InsertAtPos(UnorderedList list, string newdata, int pos)
        {
            Node temp = list.head;
            int cnt = UnorderedList.Count(list);
            Node newnode = new Node(newdata);
            if (pos > cnt && pos < 0)
            {
                Console.WriteLine("Insert valid position");
            }
            else if (pos == 1)
            {
                InsertFirst(list, newdata);
            }
            else if (pos == cnt)
            {
                InsertLast(list, newdata);
            }
            else
            {
                for (int i = 1; i < (pos - 2); i++)
                {
                    temp = temp.nextnode;
                }
                newnode.nextnode = temp.nextnode;
                temp.nextnode = newnode;
            }
            return list;
        }

        private static UnorderedList DeleteFirst(UnorderedList list)
        {
            if (list.head.nextnode == null)
            {
                list.head = null;
            }
            else
            {
                list.head = list.head.nextnode;
            }
            return list;
        }

        private static UnorderedList DeleteLast(UnorderedList list)
        {
            Node temp = list.head;
            while (temp.nextnode.nextnode != null)
            {
                temp = temp.nextnode;
            }
            temp.nextnode = null;
            return list;
        }

        private static UnorderedList DeleteAtPos(UnorderedList list, int pos)
        {
            int cnt = Count(list);
            Node temp1 = list.head;
            Node temp2 = null;
            if (pos > cnt && pos < 0)
            {
                Console.WriteLine("Enter valid position");
            }
            else if (pos == 1)
            {
                DeleteFirst(list);
            }
            else if (pos == cnt)
            {
                DeleteLast(list);
            }
            else
            {
                for (int i = 1; i < (pos - 2); i++)
                {
                    temp1 = temp1.nextnode;
                }
                temp2 = temp1.nextnode;
                temp1.nextnode = temp2.nextnode;
                temp2 = null;
            }
            return list;
        }
        private static int Count(UnorderedList list)
        {
            Node temp = list.head;
            int cnt = 0;
            while (temp != null)
            {
                cnt++;
                temp = temp.nextnode;
            }
            return cnt;
        }
        private static void Display(UnorderedList list)
        {
            Node temp = list.head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.nextnode;
            }
        }
        private static UnorderedList Search(UnorderedList list, string element)
        {
           // Console.WriteLine(list + " " + element);
            Node current = list.head;
            int count = 0;
            while (current != null)
            {
                count++;
                if (element.CompareTo(current.data) == 0)
                {
                    Console.WriteLine("Count " + count);
                    if (count == 1)
                    {
                        list = UnorderedList.DeleteFirst(list);
                    }
                    else if (count == Count(list))
                    {
                        list = UnorderedList.DeleteLast(list);
                    }
                    else
                    {
                        list = UnorderedList.DeleteAtPos(list, count);
                    }
                    return list;
                }
              
                if (element.CompareTo(current.data) < 0)
                {
                    list = UnorderedList.InsertLast(list, element);
                    return list;
                }
                current = current.nextnode;
            }
            return list;
        }
        public static void UnorderedLinkedList()
        {
            try
            {
                StreamReader sr = new StreamReader(@"D:\bridgelabz\programs\DataStructures\DataStructures\UnorderedListFile.txt");
                string fileContent = sr.ReadToEnd();
                string[] arr = fileContent.Split(" ");
                UnorderedList unol = new UnorderedList();
                for (int i = 0; i < arr.Length; i++)
                {
                    unol = InsertFirst(unol, arr[i]);
                }
                Display(unol);
                Console.WriteLine("\n Enter element to be searched : ");
                string element = Console.ReadLine();
                unol = Search(unol, element);
                Display(unol);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        }
    }
}
