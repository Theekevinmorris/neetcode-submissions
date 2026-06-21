public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int currEnd = m + n - 1;

        while(m > 0 && n > 0){
            if(nums1[m - 1] > nums2[n - 1]){
                nums1[currEnd] = nums1[m - 1];
                m--;
            }else{
                nums1[currEnd] = nums2[n - 1];
                n--;
            }
            currEnd--;
        }

        while(n > 0){
            nums1[currEnd] = nums2[n - 1];
            n--;
            currEnd--;
        }

    }
}