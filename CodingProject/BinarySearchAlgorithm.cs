using System;
namespace CodingProject
{
	public class BinarySearchAlgorithm
	{
		public BinarySearchAlgorithm()
		{
		}

		public static int BinarySearch(int[] arr, int element)
		{
			int i = 0, j = arr.Length - 1;

			while(i <= j)
			{
                int mid = i + (j - i) / 2;
                if (arr[mid] == element)
				{
                    return mid;
                }
                else if (arr[mid] > element)
				{
                    j = mid - 1;
					
                }
				else
				{
					i = mid + 1;
				}
			}

			return -1;
		}
	}
}

