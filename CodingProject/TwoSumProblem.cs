namespace CodingProject
{
    public class TwoSumProblem
	{
		public TwoSumProblem()
		{
		}

		public static int[] TwoSum(int[] numbers, int target)
		{
			Dictionary<int, int> numberDictionary = new Dictionary<int, int>();

			for (int i=0; i < numbers.Length; i++)
			{
				int compliment = target - numbers[i];
				if (numberDictionary.ContainsKey(compliment))
				{
					return new int[] { numberDictionary[compliment], i };
				}

				numberDictionary[numbers[i]] = i;
			}

			return new int[] { 0, 0 };
		}
	}
}

