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
			string reversedString = ReverseString.Reverse(text);

			return text.ToLower() == reversedString.ToLower();
		}
	}
}

