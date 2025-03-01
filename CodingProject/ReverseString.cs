using System;
using System.Text;

namespace CodingProject
{
	public class ReverseString
	{
		public ReverseString()
		{
		}

        public static string Reverse(string originalString)
		{
			StringBuilder reversedString = new StringBuilder();

			for (int i = originalString.Length-1; i >= 0; i--)
			{
				reversedString.Append(originalString[i]);
			}

			return reversedString.ToString();
		}
	}
}

