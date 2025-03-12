using System;
namespace CodingProject
{
	public class Fibonacci
	{
		public Fibonacci()
		{
		}

		public static int GetFibonacciSeriesUptoGivenNumber(int number)
		{
			if (number <= 1)
				return number;
			return GetFibonacciSeriesUptoGivenNumber(number - 1) + GetFibonacciSeriesUptoGivenNumber(number - 2);
		}
	}
}

