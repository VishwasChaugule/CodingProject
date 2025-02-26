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