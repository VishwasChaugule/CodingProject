using System;
namespace CodingProject
{
	public static class StringExtensions
	{
        public static int LengthOfLongestSubstring(this string s)
        {
            int start = 0;
            int maxLength = 0;
            HashSet<char> set = new HashSet<char>();
            for (int end = 0; end < s.Length; end++)
            {
                while (set.Contains(s[end]))
                {
                    set.Remove(s[start]);
                    start++;
                }

                set.Add(s[end]);

                maxLength = Math.Max(maxLength, end - start + 1);
            }

            return maxLength;
        }
    }
}

