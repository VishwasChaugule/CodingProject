using System;
namespace CodingProject
{
	public class QueueUsingTwoStacks
	{
		public QueueUsingTwoStacks()
		{
		}

		Stack<int> stack1 = new Stack<int>();
		Stack<int> stack2 = new Stack<int>();

		public void Enqueue(int data)
		{
			stack1.Push(data);
		}

		public int Dequeue()
		{
			if (IsEmpty())
			{
				Console.WriteLine("Queue is empty");
				return -1;
			}

			if (stack2.Count == 0)
			{
                while (stack1.Count > 0)
                {
                    stack2.Push(stack1.Pop());
                }
            }

			return stack2.Pop();
		}

		public int Peek()
		{
			if (IsEmpty())
			{
				Console.WriteLine("Queue is empty");
				return -1;
			}

			if (stack2.Count == 0)
			{
                while (stack1.Count > 0)
                {
                    stack2.Push(stack1.Pop());
                }
            }

			return stack2.Peek();
		}

		public bool IsEmpty()
		{
			return stack1.Count == 0 && stack2.Count == 0;
		}
	}
}

