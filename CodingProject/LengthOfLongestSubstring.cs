using System;
namespace CodingProject
{
	public class LengthOfLongestSubstring
	{
		public LengthOfLongestSubstring()
		{
		}

		public static int GetLengthOfLongestSubstring(string text)
		{
			int start = 0, maxLength = 0;
			HashSet<char> set = new HashSet<char>();

			for (int end = 0; end < text.Length; end++)
			{
				if (set.Contains(text[end]))
				{
					set.Remove(text[start]);
					start++;
				}

				set.Add(text[end]);
				maxLength = Math.Max(maxLength, end - start + 1);
			}

			return maxLength;
		}

    }
}

