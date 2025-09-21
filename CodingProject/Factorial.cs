namespace CodingProject
{
    public class Factorial
	{
		public Factorial()
		{
		}

		public static int GetFactorialByRecursive(int number)
		{
			if (number <=1)
				return 1;
			return number * GetFactorialByRecursive(number - 1);
		}

        public static int GetFactorial(int number)
        {
			if (number <= 1)
				return 1;

			int factorial = 1;
			for (int i = 1; i <= number; i++)
			{
				factorial *= i;
			}

			return factorial;
        }
    }
}

