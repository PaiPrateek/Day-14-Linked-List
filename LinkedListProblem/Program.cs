using System;

namespace LinkedListProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating Linked lIst");
            Console.WriteLine("\n");

            Program program = new Program();

            //Creating  Linked list by adding Data in the First Position

            program.AddLast(56);
            program.AddLast(30);
            program.AddLast(70);

            // Dispaying the above created Linked list
            program.DiplayData();


            //Searching the element 30 in the above created linked list
            var isitpresent = program.Search(30);
            Console.WriteLine("\n");
            Console.WriteLine("Element 30 is Present in the Linked list :" + isitpresent);

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

        // creating method to remove the latest element from the Linked list
        public int Pop()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is Empty");

            }
            Node X = head, Y = head;
            while (X.next != null)
            {
                Y = X;
                X = X.next;
            }
            int Z = X.data;
            Y.next = null;
            return Z;
        }
        // Creating method to Delete the elment from the Linked List
        public void Delete(int index)
        {
            if (index == 0)
            {
                head = head.next;
                return;
            }
            Node Temp = head;
            for (int i = 0; i < index - 1; i++)
            {
                Temp = Temp.next;
            }
            Temp.next = Temp.next.next;
        }

        // Creating Method to search the element in the Linked List
        public bool Search(int data)
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is Empty");
            }
            Node temp = head;
            while (temp != null)
            {
                if (temp.data.Equals(data))
                {
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }

    }   
}
