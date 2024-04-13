namespace MathNCodeCS._2024._04._05.Two.Sum;

// 1 Two Sum
// https://leetcode.com/problems/two-sum/

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        //O(N)
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int targetSubtractA = target - nums[i];
            if (dict.ContainsKey(targetSubtractA))
            {
                return new int[] { dict[targetSubtractA], i };
            }
            else
            {
                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }
            }

        }
        return null;
    }
}
