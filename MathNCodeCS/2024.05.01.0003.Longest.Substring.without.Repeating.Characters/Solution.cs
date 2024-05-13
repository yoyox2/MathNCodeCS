namespace MathNCodeCS._2024._05._01._0003.Longest.Substring.without.Repeating.Characters;

// 3 Longest Substring without Repeating Characters
// https://leetcode.com/problems/longest-substring-without-repeating-characters

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        var bag = new HashSet<char>();
        int maxWidth = 0;

        int left = 0;
        foreach (var currChar in s)
        {
            while (bag.Contains(currChar))
            {
                char x = s[left];
                bag.Remove(x);
                left++;
            }

            bag.Add(currChar);

            maxWidth = Math.Max(maxWidth, bag.Count);
        }

        return maxWidth;
    }
}
