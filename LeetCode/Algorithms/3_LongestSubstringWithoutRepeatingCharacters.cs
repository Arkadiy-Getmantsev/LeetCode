using System;
using System.Collections.Generic;

namespace Algorithms
{
    //3. Longest Substring Without Repeating Characters
    //Given a string, find the length of the longest substring without repeating characters.
    //Examples:
    //Given "abcabcbb", the answer is "abc", which the length is 3.
    //Given "bbbbb", the answer is "b", with the length of 1.
    //Given "pwwkew", the answer is "wke", with the length of 3. Note that the answer must be a substring, "pwke" is a subsequence and not a substring.

    public static class LongestSubstringWithoutRepeatingCharacters3
    {
        public static int LengthOfLongestSubstring(string s)
        {
            int n = s.Length;
            var set = new HashSet<char>();
            int ans = 0, i = 0, j = 0;

            while (i < n && j < n)
            {
                if (!set.Contains(s[j]))
                {
                    set.Add(s[j++]);
                    ans = Math.Max(ans, j - i);
                }
                else
                {
                    set.Remove(s[i++]);
                }
            }
            return ans;
        }
    }
}
