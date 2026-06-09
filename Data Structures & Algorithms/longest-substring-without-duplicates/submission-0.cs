public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int l = 0, r = 0;
        int maxSubstring = 0;
        HashSet<char> seen = new HashSet<char>();

        while(r < s.Length){
            if(seen.Contains(s[r])){
                seen.Remove(s[l]);
                l++;
            }else{
                seen.Add(s[r]);    
                r++;          
                maxSubstring = Math.Max(maxSubstring, seen.Count());
            }
            
        }
        return maxSubstring;
    }
}