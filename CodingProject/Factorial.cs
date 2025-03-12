using System;
namespace CodingProject
{
	public class Factorial
	{
		public Factorial()
		{
		}

		public static int GetFactorialOfNumber(int number)
		{
			if (number == 0)
				return 1;
			return number * GetFactorialOfNumber(number - 1);
		}
	}
}

