public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int left = 0;
        int right = nums.Length - 1;

        while(nums[left] + nums[right] != target){
            if(nums[left] + nums[right] > target){
                right--;
            }else{
                left++;
            }
        }


        return [left, right];
    }
}