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
			int left = 0, right = arr.Length - 1;

			while(left <= right)
			{
                int mid = (left + right) / 2;
                if (arr[mid] == element)
				{
                    return mid;
                }
                else if (arr[mid] > element)
				{
                    right = mid - 1;
					
                }
				else
				{
					left = mid + 1;
				}
			}

			return -1;
		}
	}
}

