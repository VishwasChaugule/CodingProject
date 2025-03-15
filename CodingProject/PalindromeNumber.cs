using System;
namespace CodingProject
{
	public class PalindromeNumber
	{
		public PalindromeNumber()
		{
		}

		public static bool IsPalindromeNumber(int number)
		{
			int reversed = 0;
			int originalNumber = number; 
			while (number > 0)
			{
				int digit = number % 10;
				reversed = (reversed * 10) + digit;
				number = number / 10;
			}

			return originalNumber == reversed;
		} 
	}
}

