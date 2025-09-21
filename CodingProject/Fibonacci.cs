using System;
namespace CodingProject
{
	public class Fibonacci
	{
		public Fibonacci()
		{
		}

		public static int GetFibonacciSeriesByRecursive(int number)
		{
			if (number <= 1)
				return number;
			return GetFibonacciSeriesByRecursive(number - 1) + GetFibonacciSeriesByRecursive(number - 2);
		}

        public static void GetFibonacciSeriesUptoGivenNumber(int number)
        {
			int a = 0;
			int b = 1;
            Console.WriteLine(a + " ");
            Console.WriteLine(b + " ");
            int c;
			for (int i = 2; i <= number; i++)
			{
				c = a + b;
				Console.WriteLine(c +" ");
				a = b;
				b = c;
			}
            
        }
    }
}

