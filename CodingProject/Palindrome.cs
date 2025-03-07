using System;
namespace CodingProject
{
	public class Palindrome
	{
		public Palindrome()
		{
		}

		public static bool IsPalindrome(string text)
		{
			int left = 0;
			int right = text.Length - 1;
			while(left < right)
			{
				if (text[left] != text[right])
					return false;
				left++;
				right--;
			}
			
			return true;
		}
	}
}

