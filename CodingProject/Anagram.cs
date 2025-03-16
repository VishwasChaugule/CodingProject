using System;
namespace CodingProject
{
	public class Anagram
	{
		public Anagram()
		{
		}

		public static bool IsAnagram(string str1, string str2)
		{
			if (str1.Length != str2.Length)
				return false;

			char[] arr1 = str1.ToLower().ToCharArray();
			char[] arr2 = str2.ToLower().ToCharArray();

			Array.Sort(arr1);
			Array.Sort(arr2);

			return new string(arr1) == new string(arr2);
		}
	}
}

