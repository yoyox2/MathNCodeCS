namespace MathNCodeCS._2024._05._09._1143.LongestCommonSubsequence;

// 1143 Longest Common Subsequence
// https://leetcode.com/problems/longest-common-subsequence/

public class Solution
{
    public int LongestCommonSubsequence(string text1, string text2)
    {
        int l1 = text1.Length;
        int l2 = text2.Length;

        var memo = new Dictionary<(int, int), int>();

        return Solve(0, 0);

        int Solve(int i, int j)
        {
            if (i == l1 || j == l2)
                return 0;
            if (memo.ContainsKey((i, j)))
                return memo[(i, j)];

            int ret = text1[i] == text2[j] ? 1 + Solve(i + 1, j + 1) : Math.Max(Solve(i, j + 1), Solve(i + 1, j));
            memo[(i, j)] = ret;
            return ret;
        }
    }
}
