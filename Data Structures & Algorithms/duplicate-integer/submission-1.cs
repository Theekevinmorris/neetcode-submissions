public class Solution {
    public bool hasDuplicate(int[] nums) {
        if(nums == null || nums.Length == 0 || nums.Length == 1)
            return false;

        HashSet<int> seenNums = new HashSet<int>();

        for(int i = 0;i < nums.Length; i++){
            if(seenNums.Contains(nums[i])){
                return true;
            }else{
                seenNums.Add(nums[i]);
            }
        }

        return false;
    }
}