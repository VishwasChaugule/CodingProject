// See https://aka.ms/new-console-template for more information
using CodingProject;

Console.WriteLine("Hello, World!");

Console.WriteLine(UniqueCharacterInAString.FindFirstUniqueChar("aabcc"));
Console.WriteLine(UniqueCharacterInAString.FindFirstUniqueChar("aabbcc"));
Console.WriteLine(UniqueCharacterInAString.FindFirstUniqueChar("zbbcc"));

int[] twosum = TwoSumProblem.TwoSum(new int[] { 2, 7, 4, 5 }, 9);
int[] twosum1 = TwoSumProblem.TwoSum(new int[] { 3, 7, 4, 5 }, 9);
int[] twosum2 = TwoSumProblem.TwoSum(new int[] { 3, 7, 4, 5 }, 2);
foreach (var num in twosum)
{
    Console.WriteLine(num);
}

foreach (var num in twosum1)
{
    Console.WriteLine(num);
}

foreach (var num in twosum2)
{
    Console.WriteLine(num);
}

Console.WriteLine(FindMissingNumber.FindMissingNumberInArray(new int[] { 1, 3, 4, 5 }));

Console.WriteLine(ValidParanthesis.CheckValidParanthesis("(({}[]))"));
Console.WriteLine(ValidParanthesis.CheckValidParanthesis("(({[]()))}"));

Console.WriteLine(ReverseString.Reverse("racecar"));
Console.WriteLine(ReverseString.Reverse("string"));

Console.WriteLine(Palindrome.IsPalindrome("RaceCar"));
Console.WriteLine(Palindrome.IsPalindrome("madam"));
Console.WriteLine(Palindrome.IsPalindrome("hello"));

Console.WriteLine(RemoveDuplicateCharacters.RemoveDuplicateCharactersFromString("aabbbcc"));