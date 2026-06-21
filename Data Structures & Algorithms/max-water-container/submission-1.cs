public class Solution {
    public int MaxArea(int[] heights) {
        int maxWater = 0;

        int left = 0;
        int right = heights.Length - 1;

        while(left < right){
            int currWater = (right - left) * Math.Min(heights[left], heights[right]);

            maxWater = Math.Max(maxWater, currWater);

            if(heights[left] <= heights[right]){
                left++;
            } else{
                right--;
            }

        }

        return maxWater;
    }
}
