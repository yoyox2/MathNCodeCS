namespace MathNCodeCS._2024._05._08._0198.HouseRobber;

// 198 House Robber
// https://leetcode.com/problems/house-robber

public class Solution
{
    public int Rob(int[] nums)
    {
        int size = nums.Length;
        if (size <= 0)
            return 0;

        var memo =
            new Dictionary<int, int>
            {
                { size - 1, nums[^1] },
                { size, 0 }
            };

        return Solve(0);

        int Solve(int start)
        {
            if (memo.TryGetValue(start, out int value))
                return value;

            int rob = nums[start] + Solve(start + 2);
            int skip = Solve(start + 1);
            int max = Math.Max(rob, skip);
            memo[start] = max;
            return max;
        }
    }
}
