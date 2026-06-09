public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> n = new HashSet<int>(nums);
        int longest = 0;

        if (nums.Length == 0)
            return 0;

        for(int i = 0; i < nums.Length; i++){
            if(n.Contains(nums[i] - 1)){
                longest += 1;
            }
        }

        return longest;

    }
}
