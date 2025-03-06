using System;
using System.Text;

namespace CodingProject
{
	public class RemoveDuplicateCharacters
	{
		public RemoveDuplicateCharacters()
		{
		}

		public static string RemoveDuplicateCharactersFromString(string inputString)
		{
			string result = string.Empty;

			for (int i = 0; i < inputString.Length; i++)
			{
				if (!result.Contains(inputString[i]))
				{
					result += inputString[i];
				}
			}

			return result;
		}
	}
}

