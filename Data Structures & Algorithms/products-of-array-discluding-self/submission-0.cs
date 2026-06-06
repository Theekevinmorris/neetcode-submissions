public class Solution {
public int[] ProductExceptSelf(int[] nums) {
    int[] result = new int[nums.Length];
    int pointer = 0;

    while (pointer < nums.Length) {
        int curr = 1;
        for (int j = 0; j < nums.Length; j++) {
            if (j != pointer) {
                curr *= nums[j];
            }
        }
        result[pointer] = curr;
        pointer += 1;
    }

    return result;
}
}
