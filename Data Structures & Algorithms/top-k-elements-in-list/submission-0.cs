public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

       var dict = new Dictionary<int, int>();

        for (int i=0;i<nums.Length;i++){
            if (dict.ContainsKey(nums[i]))
            {
                dict[nums[i]]++;
            }
            else
            {
                dict[nums[i]] = 1;
            }               
        }

        int[] result = dict
            .OrderByDescending(x => x.Value)
            .Take(k)
            .Select(x => x.Key)
            .ToArray();

        return result;
    }
}
