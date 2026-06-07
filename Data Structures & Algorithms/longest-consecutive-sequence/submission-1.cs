public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> n = new HashSet<int>(nums);
        int longest = 0;

        if (nums.Length == 0)
            return 0;

        foreach (int num in n) {
            if (!n.Contains(num - 1)) {
                int length = 1;
                while (n.Contains(num + length)) {
                    length++;
                }
                longest = Math.Max(longest, length);
            }
        }

        return longest;

    }
}
