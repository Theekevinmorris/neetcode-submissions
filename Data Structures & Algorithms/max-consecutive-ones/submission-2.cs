public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        if (nums == null || nums.Length == 0)
            return 0;
        int totalMax = 0;
        int currentStr = 0;

        for(int i  = 0; i < nums.Length; i++){
            if (nums[i] == 1){
                currentStr++;
                totalMax = Math.Max(totalMax, currentStr);
            }else{
                currentStr = 0;
            }
        }
        return totalMax;
    }
}