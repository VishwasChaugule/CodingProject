using System;
namespace CodingProject
{
	public class MaxSubArraySum
	{
		public MaxSubArraySum()
		{
		}

		public static int GetMaxSubArraySum(int[] nums)
		{
			int maxSumSoFar = nums[0], maxSumEndingHere = nums[0];
			for (int i = 1; i < nums.Length; i++)
			{
				maxSumEndingHere = Math.Max(nums[i], maxSumEndingHere + nums[i]);
				maxSumSoFar = Math.Max(maxSumSoFar, maxSumEndingHere);
			}

			return maxSumSoFar;
		}
	}
}

