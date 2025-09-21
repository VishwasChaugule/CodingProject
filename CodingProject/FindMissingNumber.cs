using System;
namespace CodingProject
{
	public class FindMissingNumber
	{
		public FindMissingNumber()
		{
		}

		public static int FindMissingNumberInArray(int[] numbers)
		{
			int n = numbers.Length + 1; // n+1 is actual size of array inclluding missing number
			int expectedSum = n * (n + 1) / 2;
			int actualSum = numbers.Sum();
			return expectedSum - actualSum;
		}
	}
}

