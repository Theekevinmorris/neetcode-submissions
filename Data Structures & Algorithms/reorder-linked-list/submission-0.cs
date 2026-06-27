/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }

Head 0
currHeadNext = head.next
Loop to find end
Update Head to end
set head to head.next


0, 

Find the end, establish a count
Update first head.next to this one, set curre to head.next
go to 
n

 */

public class Solution {
    public void ReorderList(ListNode head) {
        head = Rec(head, head.next);
    }

    private ListNode Rec(ListNode root, ListNode cur) {
        if (cur == null) {
            return root;
        }

        root = Rec(root, cur.next);
        if (root == null) {
            return null;
        }

        ListNode tmp = null;
        if (root == cur || root.next == cur) {
            cur.next = null;
        } else {
            tmp = root.next;
            root.next = cur;
            cur.next = tmp;
        }

        return tmp;
    }
}