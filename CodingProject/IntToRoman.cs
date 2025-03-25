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
    }
}

