namespace MathNCodeCS._2024._04._23._0404.Sum.of.Left.Leaves;

// 404 Sum of Left Leaves
// https://leetcode.com/problems/sum-of-left-leaves/

public class Solution
{
    public int SumOfLeftLeaves(TreeNode? root)
    {

        var bag = new Stack<(TreeNode?, bool)>();
        bag.Push((root, false));

        int ret = 0;

        while (bag.Count != 0)
        {
            var (curr, isLeft) = bag.Pop();
            if (curr is null)
            {
                continue;
            }
            if (curr.Left is null && curr.Right is null && isLeft)
                ret += curr.Val;

            bag.Push((curr.Left, true));
            bag.Push((curr.Right, false));

        }
        return ret;

        /*
         * recursive
         */

        //var ret = 0;
        //SumOfLeftLeavesInternal(root, false);
        //return ret;

        //void SumOfLeftLeavesInternal(TreeNode? node, bool isLeft)
        //{
        //    if (node == null)
        //    {
        //        return;
        //    }

        //    if (node.Left == null && node.Right == null && isLeft)
        //    {
        //        ret += node.Val;
        //    }

        //    SumOfLeftLeavesInternal(node.Left, true);
        //    SumOfLeftLeavesInternal(node.Right, false);
        //}
    }
}
