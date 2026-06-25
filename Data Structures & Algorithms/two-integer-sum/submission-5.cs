public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        var seen = new Dictionary<int,int>();

        for(int i = 0; i < nums.Length; i++){
            int temp = target - nums[i];

            if(seen.ContainsKey(temp)){
                return [seen[temp], i]; 
            }
            seen[nums[i]] = i;
        }

        return [];
    }
}