using System;
using System.Collections.Generic;

namespace _3.LongestSubstring
{
	class Program
	{
		static void Main(string[] args)
		{
			var d = LengthOfLongestSubstring("pwwkew");
			//var d = LengthOfLongestSubstring("c");
		}


		// the basic idea is, keep a dictionary which stores the characters in string as keys and their positions as values, 
		// and keep two pointers which define the max substring. move the right pointer to scan through the string , 
		// and meanwhile update the dictionary. If the character is already in the dictionary, then move the left pointer 
		// to the right of the same character last found. Note that the two pointers can only move forward.

		static int LengthOfLongestSubstring(string s)
		{
			if (s.Length == 0) return 0;

			var dic = new Dictionary<char, int>();
			int max = 0;

			// i and j are pointers. 
			// Here we can learn the two variables can be used pointers in ther for loop statement. A technique to recall for later use

			for (int i = 0, j = 0; i < s.Length; i++)
			{
				if (dic.ContainsKey(s[i]))
				{
					j = Math.Max(j, dic[s[i]] + 1);
				}
				dic[s[i]] = i;
				max = Math.Max(max, i - j + 1);
			}

			return max;

		}
	}
}
