namespace MathNCodeCS._2024._04._16._0242.Valid.Anagram;

// 242 Valid Anagram
// https://leetcode.com/problems/valid-anagram/

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        char[] sArray = s.ToCharArray();
        char[] tArray = t.ToCharArray();

        Array.Sort(sArray);
        Array.Sort(tArray);

        string sortedS = String.Join("", sArray);
        string sortedT = String.Join("", tArray);

        if (!sortedS.Equals(sortedT))
        {
            return false;
        }

        return true;
    }
}
