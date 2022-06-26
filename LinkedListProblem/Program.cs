﻿using System;

namespace LinkedListProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating Linked lIst");
            Console.WriteLine("\n");

            Program program = new Program();

            //Creating  Linked list by adding Data in the Last Position

            program.AddLast(56);
            program.AddLast(70);

            // insert the 30 in 1st Index (between 56 and 70)

            program.Insert(1,30);
            program.DiplayData();

        }

        // Creating Node
        public class Node
        {
            public int data;
            public Node next;

            public Node(int data)
            {
                this.data = data;
            }
        }


        public Node head;

        // Creting Method to Add data in First position in the Linked list
        public bool AddFirst(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
                return true;
            }
            node.next = head;
            head = node;
            return true;
        }

        // Creating Method to Display the data in Linked lIst
        public void DiplayData()
        {
            if (head == null)
            {
                Console.WriteLine("Linkedlist is Empty");
            }
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " " );
                temp = temp.next;
            }
        }
        // Creating method to add data in Last postion in the Linked list
        public bool AddLast(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
                return true;
            }
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = node;
            return true;
        }

        // Creating Method to Insert the data in the required index position in the Linked list
        public bool Insert(int ind, int data)
        {
            Node n = new Node(data);
            if (ind == 0)
            {
                n.next = head.next;
                head = n;
                return true;
            }
            Node t = head, pre = null;
            while (ind > 0 && t != null)
            {
                ind--;
                pre = t;
                t = t.next;
            }
            if (ind == 0)
            {
                pre.next = n;
                n.next = t;
                return true;
            }
            else
            {
                Console.WriteLine("Index is not in range");
                return false;
            }

        }
    }   
}
