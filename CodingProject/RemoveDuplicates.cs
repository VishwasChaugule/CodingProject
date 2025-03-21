using System;
namespace CodingProject
{
	public class RemoveDuplicates
	{
		public RemoveDuplicates()
		{
		}

        public static int RemoveDuplicatesNumbers(int[] nums)
        {
            HashSet<int> uniqueSet = new HashSet<int>();
            int index = 0;

            foreach (int num in nums)
            {
                if (uniqueSet.Add(num))
                {  // If the number is added (not already in set)
                    nums[index++] = num;   // Place the unique number at the current index
                }
            }

            return index;  // The length of the array with unique elements
        }
    }
}

