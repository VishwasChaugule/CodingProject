using System;
namespace CodingProject
{
	public class ValidParanthesis
	{
		public ValidParanthesis()
		{
		}

		public static bool CheckValidParanthesis(string input)
		{
			Stack<char> openingParanthesis = new Stack<char>();
			foreach (var character in input)
			{
				if (character == '(' || character == '[' || character == '{')
				{
					openingParanthesis.Push(character);
				}

				if(character == ')' || character == ']' || character == '}')
				{
					if (openingParanthesis.Count() == 0)
						return false;
					var topElement = openingParanthesis.Peek();
					if ((character == ')' && topElement == '(') || (character == ']' && topElement == '[')
						|| (character == '}' && topElement == '{'))
					{
						openingParanthesis.Pop();
					}
					else
					{
						return false;
					}
				}
			}

			if (openingParanthesis.Count() == 0)
				return true;
			return false;
		}
	}
}

