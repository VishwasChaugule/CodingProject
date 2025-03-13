using System;
namespace CodingProject
{
	public class CountCharacterOccurrences
	{
		public CountCharacterOccurrences()
		{
		}

		public static Dictionary<char, int> GetCountCharacterOccurrences(string text)
		{
			Dictionary<char, int> characterCountDictionary = new Dictionary<char, int>();
			foreach (var character in text)
			{
				if (characterCountDictionary.ContainsKey(character))
				{
					characterCountDictionary[character]++;
				}
				else
				{
					characterCountDictionary[character] = 1;
				}
			}

			return characterCountDictionary;
		}
    }
}

