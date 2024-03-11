/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<int> RightSideView(TreeNode root) {
        List<int> result = new List<int>();

        if (root == null)
            return result;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            int levelSize = queue.Count;

            for (int i = 0; i < levelSize; i++)
            {
                TreeNode currentNode = queue.Dequeue();

                // Only add the rightmost node at each level
                if (i == levelSize - 1)
                    result.Add(currentNode.val);

                if (currentNode.left != null)
                    queue.Enqueue(currentNode.left);

                if (currentNode.right != null)
                    queue.Enqueue(currentNode.right);
            }
        }

        return result;
    }
}