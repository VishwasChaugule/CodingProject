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

		public static bool IsPalindromeWithRecursive(string text, int start, int end)
		{
			if (start >= end)
			{
				return true;
			}

			if (text[start] != text[end])
			{
				return false;
			}

			return IsPalindromeWithRecursive(text, start + 1, end - 1);
		} 
	}
}

