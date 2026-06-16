public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        if (nums == null || nums.Length == 0)
            return 0;
        int totalMax = 0;
        int currentStr = 0;

        for(int i  = 0; i < nums.Length; i++){
            if (nums[i] == 1){
                currentStr++;
            }else{
                totalMax = Math.Max(totalMax, currentStr);                
                currentStr = 0;
            }
        }
        return Math.Max(totalMax, currentStr);
    }
}