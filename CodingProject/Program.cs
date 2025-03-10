// See https://aka.ms/new-console-template for more information
using CodingProject;

Console.WriteLine("Hello, World!");

Console.Write("Unique character in aabcc is ");
Console.WriteLine(UniqueCharacterInAString.FindFirstUniqueChar("aabcc"));

Console.Write("Unique character in aabbcc is ");
Console.WriteLine(UniqueCharacterInAString.FindFirstUniqueChar("aabbcc"));

Console.Write("Unique character in zbbcc is ");
Console.WriteLine(UniqueCharacterInAString.FindFirstUniqueChar("zbbcc"));

Console.Write("Two sum problem { 2, 7, 4, 5 }, 9 is ");
int[] twosum = TwoSumProblem.TwoSum(new int[] { 2, 7, 4, 5 }, 9);
Console.WriteLine(string.Join(",", twosum));

Console.Write("Two sum problem { 3, 7, 4, 5 }, 9 is ");
int[] twosum1 = TwoSumProblem.TwoSum(new int[] { 3, 7, 4, 5 }, 9);
Console.WriteLine(string.Join(",", twosum1));

Console.Write("Two sum problem { 3, 7, 4, 5 }, 2 is ");
int[] twosum2 = TwoSumProblem.TwoSum(new int[] { 3, 7, 4, 5 }, 2);
Console.WriteLine(string.Join(",", twosum2));

Console.Write("Mising number in array { 1, 3, 4, 5 } is ");
Console.WriteLine(FindMissingNumber.FindMissingNumberInArray(new int[] { 1, 3, 4, 5 }));

Console.Write("Valid Paranthessis (({}[])) : ");
Console.WriteLine(ValidParanthesis.CheckValidParanthesis("(({}[]))"));
Console.Write("Valid Paranthessis (({[]()))} : ");
Console.WriteLine(ValidParanthesis.CheckValidParanthesis("(({[]()))}"));

Console.Write("Reverse of racecar is ");
Console.WriteLine(ReverseString.Reverse("racecar"));
Console.Write("Reverse of string is ");
Console.WriteLine(ReverseString.Reverse("string"));

Console.WriteLine($"Is racecar Palindrome: {Palindrome.IsPalindrome("racecar")}");
Console.WriteLine($"Is madam Palindrome: {Palindrome.IsPalindrome("madam")}");
Console.WriteLine($"Is hello Palindrome: {Palindrome.IsPalindrome("hello")}");

Console.Write("Remove Duplicate Characters From aabbbcc String :");
Console.WriteLine(RemoveDuplicateCharacters.RemoveDuplicateCharactersFromString("aabbbcc"));

Console.Write("Merged Array of new int[] { 1, 3, 5 }, new int[] { 2, 4, 6 } : ");
int[] mergedArray = MergeSortedArrays.MergeTwoSortedArrays(new int[] { 1, 3, 5 }, new int[] { 2, 4, 6 });
Console.WriteLine(string.Join(",", mergedArray));


Console.WriteLine("Stack using Linked List");
var stack = new CodingProject.StackwithLinkedList.Stack();
Console.WriteLine($"Is Stack empty : {stack.IsEmpty()}");
stack.Push(1);
stack.Push(2);
stack.Push(3);
Console.WriteLine($"Top element is: {stack.Peek()}");
stack.Pop();
Console.WriteLine($"Top element is: {stack.Peek()}");
Console.WriteLine($"Is Stack empty : {stack.IsEmpty()}");