using System.Linq;

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
        //Solution 1
        //O(N) 63ms
        var counter = Enumerable.Repeat(0, 26).ToArray();
        foreach (char c in s)
        {
            int idx = c - 'a';
            counter[idx]++;
        }
        foreach (char c in t)
        {
            int idx = c - 'a';
            if (counter[idx] == 0)
            {
                return false;
            }

            counter[idx]--;
        }
        return true;


        //Solution 2
        //O(N) 53ms
        //var counter1 = s.GroupBy(s => s).ToDictionary(c => c.Key, c => c.Count());

        //foreach (var c in t)
        //{
        //    if (!counter1.ContainsKey(c) || counter1[c] == 0)
        //        return false;

        //    counter1[c]--;
        //}

        //return counter1.Where(c => c.Value > 0).Count() == 0;


        //Solution 3
        //O(N) 64ms
        //char[] sArray = s.ToCharArray();
        //char[] tArray = t.ToCharArray();

        //Array.Sort(sArray);
        //Array.Sort(tArray);

        //string sortedS = String.Join("", sArray);
        //string sortedT = String.Join("", tArray);

        //if (!sortedS.Equals(sortedT))
        //{
        //    return false;
        //}

        //return true;


        //Solution 4
        //O(N) 108ms

        //return s.OrderBy(c => c).SequenceEqual(t.OrderBy(c => c));
    }
}
