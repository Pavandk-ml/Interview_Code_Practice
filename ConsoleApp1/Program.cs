﻿


using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

#region Words with most unique letters

//class Program
//{
//    static void Main()
//    {
//        List<string> words = new List<string> { "apple", "banana", "cherry", "strawberry", "blueberry", "kiwi", "equalizer", "boarding" };

//        var sortedWords = words
//            .Select(word => new { Word = word, UniqueCount = word.ToHashSet().Count })
//            .OrderByDescending(x => x.UniqueCount)
//            .ThenBy(x => x.Word)
//            .ToList();

//        var topEntry = sortedWords.First();

//        Console.WriteLine("Word with the most unique letters (sorted lexicographically) and its unique letter count:");
//        Console.WriteLine($"{topEntry.Word}: {topEntry.UniqueCount}");
//    }
//}
#endregion

#region Optimal Priority Sequence

//class Program
//{
//    static List<int> GetOptimalPriority(List<int> priority)
//    {
//        List<int> cpuBound = priority.Where(x => x % 2 == 1).OrderBy(x => x).ToList();
//        List<int> ioBound = priority.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

//        List<int> result = new List<int>();
//        int cpuIndex = 0, ioIndex = 0;

//        foreach (var task in priority)
//        {
//            if (task % 2 == 1)
//                result.Add(cpuBound[cpuIndex++]);
//            else
//                result.Add(ioBound[ioIndex++]);
//        }

//        return result;
//    }

//    static void Main()
//    {
//        List<int> priority = new List<int> { 2,4,6,4,3,3,3,2,0 };
//        List<int> optimalSequence = GetOptimalPriority(priority);

//        Console.WriteLine("Lexicographically smallest priority sequence:");
//        Console.WriteLine(string.Join(", ", optimalSequence));
//    }
//}

#endregion

#region Getrting Count without for loop 

//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 0, 0, 0, 0, 0, 1, 1, 1, 1, 1 };

//        int countZeros = numbers.Count(x => x == 0);
//        int countOnes = numbers.Count(x => x == 1);

//        Console.WriteLine($"Number of 0's: {countZeros}");
//        Console.WriteLine($"Number of 1's: {countOnes}");
//    }
//}

#endregion


#region Getting Leap Year

//class Program
//{
//    static bool IsLeapYear(int year)
//    {
//        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
//    }

//    static void Main()
//    {
//        Console.Write("Enter a year: ");
//        int year = int.Parse(Console.ReadLine());

//        if (IsLeapYear(year))
//            Console.WriteLine($"{year} is a leap year.");
//        else
//            Console.WriteLine($"{year} is not a leap year.");
//    }
//}

#endregion

#region String Palindrom (including sentences and special character)
//class Program
//{
//    static bool IsPalindrome(string input)
//    {
//        input = input.Replace(" ", "");
//        input = Regex.Replace(input, "[^a-zA-Z]", "").ToLower();
//        int left = 0;
//        int right = input.Length - 1;

//        while (left < right)
//        {
//            if (input[left] != input[right])
//                return false;

//            left++;
//            right--;
//        }

//        return true;
//    }

//    static void Main()
//    {
//        Console.Write("Enter a string: ");
//        string input = Console.ReadLine();

//        if (IsPalindrome(input))
//            Console.WriteLine($"'{input}' is a palindrome.");
//        else
//            Console.WriteLine($"'{input}' is not a palindrome.");
//    }
//}

#endregion

#region number Palindrome
//class Program
//{
//    static bool IsPalindrome(int num)
//    {
//        int original = num;
//        int reversed = 0;

//        while (num > 0)
//        {
//            int digit = num % 10;  // Extract last digit
//            reversed = reversed * 10 + digit;  // Build the reversed number
//            num /= 10;  // Remove last digit
//        }

//        return original == reversed;
//    }

//    static void Main()
//    {
//        Console.Write("Enter a number: ");
//        int number = int.Parse(Console.ReadLine());

//        if (IsPalindrome(number))
//            Console.WriteLine($"{number} is a palindrome.");
//        else
//            Console.WriteLine($"{number} is not a palindrome.");
//    }
//}

#endregion

#region Logical Question on 
//class Parent
//{
//    public Parent(int x)  // Parameterized constructor
//    {
//        Console.WriteLine("Parent constructor called with value: " + x);
//    }
//}

//class Child : Parent
//{
//    public Child()  // Default constructor
//    {
//        Console.WriteLine("Child constructor called.");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Child obj = new Child(); // ❌ ERROR: No default constructor in Parent class
//    }
//}

#endregion

#region  Methodoverloding different return type and same ppparameter.
//using System;

//class Test
//{
//    public int Show(int x) // Method 1
//    {
//        return x * 2;
//    }

//    public double Show(int x) // ❌ Compilation Error: Same parameter list
//    {
//        return x * 2.5;
//    }

//    static void Main()
//    {
//        Test obj = new Test();
//        int result = obj.Show(10);  // ❌ ERROR: Ambiguous method call
//        Console.WriteLine(result);
//    }
//}
#endregion

#region Valid Paranthesis 
//public class Solution
//{
//    public bool IsValid(string s)
//    {
//        Stack<char> stackchar = new Stack<char>();
//        Dictionary<char, char> DictChar = new Dictionary<char, char>(){
//                {')','('},
//                {']','['},
//                {'}','{'}
//        };

//        foreach (char a in s)
//        {
//            if (DictChar.ContainsKey(a))
//            {
//                var TopElement = stackchar.Count > 0 ? stackchar.Pop() : '#';
//                if (TopElement == DictChar[a])
//                {
//                    continue;
//                }
//                else
//                {
//                    return false;
//                }

//            }
//            else
//            {
//                stackchar.Push(a);
//            }



//        }
//        return stackchar.Count == 0;


//    }

//    static void Main(string[] args)
//    {
//        Solution s = new Solution();
//         var result = s.IsValid("(){}}{");
//        //string sa = " hello new world ";

//        //Console.WriteLine(sa.Trim().Split(' ').Last().Length);
//        Console.WriteLine(result);
//    }
//}
#endregion

#region  Merge two sorted List

 public class ListNode
{
      public int val;
      public ListNode next;
     public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
            }
  }

public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode dummy = new ListNode();
        ListNode current = dummy;

        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                current = current.next = new ListNode();
                current.val = list1.val;
                list1 = list1.next;
            }
            else
            {
                current = current.next = new ListNode();
                current.val = list2.val;
                list2 = list2.next;
            }
            current.next = new ListNode();
            //current = current.next;
        }

        if (list1 == null)
        {
            current.next = list2;
        }
        if (list2 == null)
        {
            current.next = list1;
        }

        return dummy.next;

    }

    static void Main(string[] args)
    {
        ListNode list1 = new ListNode(1, new ListNode(3, new ListNode(5)));
        ListNode list2 = new ListNode(2, new ListNode(4, new ListNode(6)));
        Solution s = new Solution();
        var result = s.MergeTwoLists(list1, list2);
        //string sa = " hello new world ";

        //Console.WriteLine(sa.Trim().Split(' ').Last().Length);
        Console.WriteLine(result);
    }
}


#endregion
