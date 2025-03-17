using System;
namespace CodingProject
{
	public class LargestNumber
	{
		public LargestNumber()
		{
		}

		public static int GetLargestNumber(int[] numbers)
		{
			int largest = numbers[0];

			for (int i = 1; i < numbers.Length; i++)
			{
				if (numbers[i] > largest)
					largest = numbers[i];
			}

			return largest;
		}

		public static int GetSecondLargestNumber(int[] numbers)
		{
			int largest = numbers[0];
			int secondLargest = numbers[0];

			for (int i = 1; i < numbers.Length; i++)
			{
				if (numbers[i] > largest)
				{
					secondLargest = largest;
					largest = numbers[i];
				}
				else if (numbers[i] > secondLargest && numbers[i] < largest)
				{
					secondLargest = numbers[i];
				}
			}

			return secondLargest;
		}
	}
}

