using System;
namespace CodingProject
{
	public class FizBuzzProblem
	{
		public FizBuzzProblem()
		{
		}

		public static void FizBuzz()
		{
			for (int i = 0; i < 100; i++)
			{
				if (i%3 == 0 && i % 5 == 0)
				{
					Console.WriteLine("FizBuzz");
				}
				else if (i % 3 == 0)
				{
					Console.WriteLine("Fizz");
				}
				else if (i % 5 == 0)
				{
					Console.WriteLine("Buzz");
				}
				else
				{
					Console.WriteLine(i);
				}
			}
		}
	}
}

