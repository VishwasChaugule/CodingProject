using System;
namespace CodingProject
{
	public class MergeSortedArrays
	{
		public MergeSortedArrays()
		{
		}

		public static int[] MergeTwoSortedArrays(int[] num1, int[] num2)
		{
			int i = 0, j = 0, k = 0;
			var result = new int[num1.Length + num2.Length];

			while(i < num1.Length && j < num2.Length)
			{
				if (num1[i] < num2[j])
				{
					result[k++] = num1[i++];
				}
				else
				{
					result[k++] = num2[j++];
				}
			}

			while(i < num1.Length)
			{
				result[k++] = num1[i++];
			}

			while (j < num2.Length)
			{
				result[k++] = num2[j++];
			}

			return result;
		}
	}
}

