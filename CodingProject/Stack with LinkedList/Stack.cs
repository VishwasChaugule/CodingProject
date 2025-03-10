using System;
namespace CodingProject.StackwithLinkedList
{
	public class Stack
	{
		private Node top;

		public Stack()
		{
			top = null;
		}

		public void Push(int data)
		{
			Node newNode = new Node(data);
			newNode.Next = top;
			top = newNode;
			Console.WriteLine($"{data} pushed to the stack");
		}

		public int Pop()
		{
			if (IsEmpty())
			{
				Console.WriteLine("Stack is empty");
				return -1;
			}

			int poppedData = top.Data;
			top = top.Next;
            Console.WriteLine($"{poppedData} popped from stack.");
            return poppedData;
		}

		public int Peek()
		{
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }

			return top.Data;
        }

		public bool IsEmpty()
		{
			return top == null;
		}
	}
}

