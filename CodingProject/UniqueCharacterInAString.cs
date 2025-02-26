using System;
namespace CodingProject
{
	public class UniqueCharacterInAString
	{
		public UniqueCharacterInAString()
		{
		}

        public static char? FindFirstUniqueChar(string text)
        {
            Dictionary<char, int> characters = new Dictionary<char, int>();

            foreach (var character in text)
            {
                if (!characters.ContainsKey(character))
                {
                    characters[character] = 1;
                }
                else
                {
                    characters[character]++;
                }
            }

            foreach (var character in text)
            {
                if (characters[character] == 1)
                {
                    return character;
                }
            }

            return null;
        }
    }
}

