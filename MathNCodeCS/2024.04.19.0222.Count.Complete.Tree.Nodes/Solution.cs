namespace MathNCodeCS._2024._04._19._0222.Count.Complete.Tree.Nodes;

// 222 Count Complete Tree Node
// https://leetcode.com/problems/count-complete-tree-nodes/

public class Solution
{

    public int CountNodes(TreeNode? root)
    {
        return CountNodesInternal(root);

        int CountNodesInternal(TreeNode? node)
        {
            return node is null ? 0 : 1 + CountNodesInternal(node.Left) + CountNodesInternal(node.Right);
        }
    }

    //public int CountNodes(TreeNode? root)
    //{
    //    return CountNodesInternal(root);
    //}

    //private static int CountNodesInternal(TreeNode? node)
    //{
    //    return node is null ? 0 : 1 + CountNodesInternal(node.Left) + CountNodesInternal(node.Right);
    //}
}
