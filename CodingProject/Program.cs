// See https://aka.ms/new-console-template for more information
using CodingProject;
using CodingProject.LinkedList;

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

Console.WriteLine("Palindrome: ");
Console.WriteLine($"Is racecar Palindrome: {Palindrome.IsPalindrome("racecar")}");
Console.WriteLine($"Is madam Palindrome: {Palindrome.IsPalindrome("madam")}");
Console.WriteLine($"Is hello Palindrome: {Palindrome.IsPalindrome("hello")}");

Console.WriteLine("Palindrome with recursive: ");
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

Console.WriteLine($"Longest Substring Without Repeating Characters for abcabcbb is {LengthOfLongestSubstring.GetLengthOfLongestSubstring("abcabcbb")}");

Console.WriteLine("Implement Queue is using two stacks");
QueueUsingTwoStacks queue = new QueueUsingTwoStacks();
Console.WriteLine($"Is queue empty : {queue.IsEmpty()}");
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);
Console.WriteLine($"Is queue empty : {queue.IsEmpty()}");
Console.WriteLine($"Dequeue: {queue.Dequeue()}");
Console.WriteLine($"Peek element: {queue.Dequeue()}");

Console.WriteLine($"Factorial of 0: {Factorial.GetFactorial(0)}");
Console.WriteLine($"Factorial of 1: {Factorial.GetFactorial(1)}");
Console.WriteLine($"Factorial of 5: {Factorial.GetFactorial(5)}");

Console.WriteLine($"Fibonacci series upto 5:");

for (int i = 0; i <= 5; i++)
{
    Console.WriteLine(Fibonacci.GetFibonacciSeriesByRecursive(i));
}


Console.WriteLine($"Fibonacci series upto 5:");


Fibonacci.GetFibonacciSeriesUptoGivenNumber(5);


Console.WriteLine("Max Sub Array Sum");
Console.WriteLine($"[1,-2, 3, 4, -3, 4] : {MaxSubArraySum.GetMaxSubArraySum(new int[] { 1, -2, 3, 4, -3, 4 })}");

Console.WriteLine("FizBuzz Problem");
FizBuzzProblem.FizBuzz();

Console.WriteLine("Count Character Occurrences");
var characterCountOccurrences = CountCharacterOccurrences.GetCountCharacterOccurrences("aabccccddddd");
foreach (var item in characterCountOccurrences)
{
    Console.WriteLine($"{item.Key} : {item.Value}");
}

Console.WriteLine($"Is 121 palindrome: {PalindromeNumber.IsPalindromeNumber(121)}");
Console.WriteLine($"Is 123 palindrome: {PalindromeNumber.IsPalindromeNumber(123)}");

string result = ReverseWords.ReverseWordsInAString("Hello World from CodingProject");
Console.WriteLine(result); // Output: "CodingProject from World Hello"

Console.WriteLine($"Is Anagram : {Anagram.IsAnagram("Listen","Silent")}");

Console.WriteLine($"Is Anagram : {Anagram.IsAnagram("Hello", "World")}");

Console.WriteLine("Binary Search");

int[] arr = { 1, 3, 5, 7, 9, 11, 13, 15 };
Console.WriteLine("Enter the number to search:");
int target = int.Parse(Console.ReadLine());
int index = BinarySearchAlgorithm.BinarySearch(arr, target);
if (index == -1)
    Console.WriteLine("Number not found.");
else
    Console.WriteLine($"Number found at index: {index}");

Console.WriteLine($"Largest Number : {LargestNumber.GetLargestNumber(arr)}");
Console.WriteLine($"Second Largest Number : {LargestNumber.GetSecondLargestNumber(arr)}");

Console.WriteLine($"Smallest Number : {SmallestNumber.GetSmallestNumber(arr)}");
Console.WriteLine($"Second Smallest Number : {SmallestNumber.GetSecondSmallestNumber(arr)}");

Console.WriteLine("Find common element");

int[] arr1 = { 1, 2, 3, 4, 5 };
int[] arr2 = { 4, 5, 6, 7 };

List<int> common = CommonElements.FindCommonElements(arr1, arr2);
Console.WriteLine($"Count: {common.Count}");
foreach (var item in common)
{
    Console.Write(item + " ");
}
Console.WriteLine();
Console.WriteLine("Remove duplicate numbers");
int[] nums = { 1, 1, 2, 2, 3, 4, 4 };

int newLength = RemoveDuplicates.RemoveDuplicatesNumbers(nums);
Console.WriteLine(newLength);  // Output: 4
Console.WriteLine(string.Join(", ", nums.Take(newLength)));

Console.WriteLine("Linked List Reverse");
var linkedList = LinkedListOperation.CreateLinkedList();
Console.WriteLine("Before Reverse");
LinkedListOperation.PrintList(linkedList);
Console.WriteLine("After Reverse");
var reversedList = LinkedListOperation.Reverse(linkedList);
LinkedListOperation.PrintList(reversedList);

Console.WriteLine("Longest Substring without repeating characters");
Console.WriteLine("pwwpa".LengthOfLongestSubstring());
Console.WriteLine("abcd".LengthOfLongestSubstring());
Console.WriteLine("aaaa".LengthOfLongestSubstring());

Console.WriteLine("Int to Roman");
Console.WriteLine(IntToRoman.IntToRomanConversion(58));
Console.WriteLine(IntToRoman.IntToRomanConversion(3749));

Console.WriteLine("Roman to Int");
Console.WriteLine(IntToRoman.RomanToInt("III"));
Console.WriteLine(IntToRoman.RomanToInt("MCMXCIV"));

Console.WriteLine("Merge two Lists");
var list1 = LinkedListOperation.CreateLinkedList();
var list2 = LinkedListOperation.CreateLinkedList();

var mergedList = LinkedListOperation.MergeTwoLists(list1, list2);

LinkedListOperation.PrintList(mergedList);
