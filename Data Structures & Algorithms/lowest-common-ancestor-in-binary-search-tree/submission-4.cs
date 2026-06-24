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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
    
        int smaller = Math.Min(p.val,q.val);
        int larger = Math.Max(p.val,q.val);

        if (root.val < smaller){
             return LowestCommonAncestor(root.right,p,q);
        } else if (root.val > larger){
             return LowestCommonAncestor(root.left,p,q);
        } else {
            return root;
        } 
    }
}
