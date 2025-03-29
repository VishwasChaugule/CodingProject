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

        public static Node MergeTwoLists(Node list1, Node list2)
        {
            Node list3 = new Node(0);
            Node current = list3;
            while (list1 != null && list2 != null)
            {
                if (list1.Data < list2.Data)
                {
                    current.Next = list1;
                    list1 = list1.Next;
                }
                else
                {
                    current.Next = list2;
                    list2 = list2.Next;
                }

                current = current.Next;
            }

            if (list1 != null)
            {
                current.Next = list1;
            }
            else
            {
                current.Next = list2;
            }

            return list3.Next;
        }
    }
}

