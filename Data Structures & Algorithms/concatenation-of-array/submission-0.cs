public class Solution {
    public int[] GetConcatenation(int[] nums) {
        var nums2 = nums.Concat(nums).ToArray();

        return nums2;
    }
}