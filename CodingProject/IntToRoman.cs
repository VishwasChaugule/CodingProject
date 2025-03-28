using System;
namespace CodingProject
{
	public class IntToRoman
	{
		public IntToRoman()
		{
		}

        public static string IntToRomanConversion(int num)
        {
            var romanMap = new (int, string)[]
                {
        (1000, "M"), (900, "CM"), (500, "D"), (400, "CD"),
        (100, "C"), (90, "XC"), (50, "L"), (40, "XL"),
        (10, "X"), (9, "IX"), (5, "V"), (4, "IV"),
        (1, "I")
                };

            string roman = string.Empty;

            foreach (var (value, symbol) in romanMap)
            {
                while (num >= value)
                {
                    roman += symbol;
                    num -= value;
                }
            }
            return roman;
        }

        public static int RomanToInt(string s)
        {
            Dictionary<char, int> romanNumbers = new Dictionary<char, int> {
        {'I', 1},  {'V', 5}, {'X', 10}, {'L',50}, {'C',100}, {'D',500}, {'M',1000}
      };

            int result = 0;
            int prevValue = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                int currentValue = romanNumbers[s[i]];

                if (currentValue < prevValue)
                {
                    result -= currentValue; // Subtract when a smaller value is before a larger one
                }
                else
                {
                    result += currentValue; // Otherwise, add it
                }

                prevValue = currentValue;
            }

            return result;
        }
    }
}

