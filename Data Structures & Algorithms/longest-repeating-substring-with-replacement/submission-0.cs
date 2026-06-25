public class Solution {
    public int CharacterReplacement(string s, int k) {
        if (s.Length == 1) return 1;
        int maxSubstring = 0;
        int left = 0;

        while(left < s.Length - 1){          
            char curr = s[left];
            int currMax = 0;
            int remainingFlips = k;            

            for(int i = left; i < s.Length; i++){
                if(s[i] == curr){
                    currMax++;
                }else if(remainingFlips > 0){
                    currMax++;
                    remainingFlips--;
                }else{
                    maxSubstring = Math.Max(maxSubstring, currMax);
                    break;
                }
                maxSubstring = Math.Max(maxSubstring, currMax);
            }
            left++;

        }

        return maxSubstring;
        

    }
}
