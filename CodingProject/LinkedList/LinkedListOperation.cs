using System;
using CodingProject.StackwithLinkedList;

namespace CodingProject.LinkedList
{
	public class LinkedListOperation
	{
		public LinkedListOperation()
		{
		}

		public static Node Reverse(Node head)
		{
			Node prev = null;
			Node current = head;

			while (current != null)
			{
				Node nextNode = current.Next;
				current.Next = prev;
				prev = current;
				current = nextNode;
			}

			return prev;
		}

        public static void PrintList(Node head)
        {
            while (head != null)
            {
                Console.Write(head.Data + " ");
                head = head.Next;
            }
            Console.WriteLine();
        }

		public static Node CreateLinkedList()
		{
            Node head = new Node(1);
            head.Next = new Node(2);
            head.Next.Next = new Node(3);
            head.Next.Next.Next = new Node(4);
            head.Next.Next.Next.Next = new Node(5);

			return head;
        }
    }
}

