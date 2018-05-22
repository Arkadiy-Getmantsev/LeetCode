namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var result1 = TwoSum1.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            var result2 = AddTwoNumbers2.AddTwoNumbers(
                new ListNode(2)
                {
                    next = new ListNode(4)
                    {
                        next = new ListNode(3)
                    }
                },
                new ListNode(5)
                {
                    next = new ListNode(6)
                    {
                        next = new ListNode(4)
                    }
                });
            var result3 = LongestSubstringWithoutRepeatingCharacters3.LengthOfLongestSubstring("abcabcbb");
            var result4 = MedianOfTwoSortedArrays4.FindMedianSortedArrays(new int[] { 1, 3 }, new int[] { 2 });
        }
    }
}
