namespace CodingProject
{
    public class ReverseWords
    {
        public ReverseWords()
        {
        }

        public static string ReverseWordsInAString(string text)
        {
            // Corrected: Remove the extra closing parenthesis and use double quotes for space separator
            return string.Join(" ", text.Split(' ').Reverse());
        }
    }
}