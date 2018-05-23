using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public static class LongestPalindromicSubstring5
    {
        public static string LongestPalindrome(string s)
        {
            int maxLength = 0;
            bool checkForSimilarCharacters = false;
            var results = new Dictionary<int, string>();

            if (string.IsNullOrEmpty(s) || s.Length > 1000)
                return string.Empty;

            if (s.Length == 1 || s.Distinct().ToArray().Length == 1)
                return s;

            for (int i = 0; i < s.Length; i++)
            {
                checkForSimilarCharacters = true;

                for (int x = i; x < s.Length; x++)
                {
                    if (s[i] != s[x])
                    {
                        checkForSimilarCharacters = false;
                        continue;
                    }
                        
                    if (checkForSimilarCharacters && x < s.Length - 1 && s[i] == s[x + 1])
                        continue;

                    if (x - i < maxLength)
                        continue;

                    var subString = s.Substring(i, x - i + 1);

                    if (subString.Length == 1)
                        continue;

                    char[] chars = subString.ToCharArray();

                    Array.Reverse(chars);

                    if (subString == new string(chars))
                    {
                        maxLength = subString.Length;
                        results.Add(subString.Length, subString);
                    }
                }
            }

            return results.Any() ? results[maxLength] : s[0].ToString();
        }
    }
}
