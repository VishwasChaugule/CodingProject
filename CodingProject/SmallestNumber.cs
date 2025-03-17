using System;
namespace CodingProject
{
	public class SmallestNumber
	{
		public SmallestNumber()
		{
		}

        public static int GetSmallestNumber(int[] numbers)
        {
            int smallest = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < smallest)
                    smallest = numbers[i];
            }

            return smallest;
        }

        public static int GetSecondSmallestNumber(int[] numbers)
        {
            int smallest = numbers[0];
            int secondSmallest = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < smallest)
                {
                    secondSmallest = smallest;
                    smallest = numbers[i];
                }
                else if ((numbers[i] < secondSmallest || secondSmallest == smallest) && numbers[i] > smallest)
                {
                    secondSmallest = numbers[i];
                }
            }

            return secondSmallest;
        }
    }
}

