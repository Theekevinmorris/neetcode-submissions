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
    public List<List<int>> LevelOrder(TreeNode root) {     
        if (root == null) return new List<List<int>>();

        List<List<int>> res = new List<List<int>>();
        Queue<TreeNode> currentLevel = new Queue<TreeNode>();

        currentLevel.Enqueue(root);

        while (currentLevel.Count > 0) {
            List<int> level = new List<int>();
            int levelCount = currentLevel.Count;
            
            for (int i = 0; i < levelCount; i++) {
                var node = currentLevel.Dequeue();
                level.Add(node.val);
                if (node.left != null)  currentLevel.Enqueue(node.left);
                if (node.right != null) currentLevel.Enqueue(node.right);

            }
            res.Add(level);
        } 

        return res;   

    }
}
