using System;
namespace CodingProject
{
	public class CommonElements
	{
		public CommonElements()
		{
		}

		public static List<int> FindCommonElements(int[] arr1, int[] arr2)
		{
			HashSet<int> set1 = new HashSet<int>(arr1);
			List<int> common = new List<int>();

			foreach (var item in arr2)
			{
				if (set1.Contains(item))
				{
					common.Add(item);
				}
			}

			return common;
		}

    }
}

