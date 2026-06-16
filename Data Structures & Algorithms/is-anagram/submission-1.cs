public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;
        
        var dictS = new Dictionary<char, int>();
        var dictT = new Dictionary<char, int>();


        foreach(char c in s){
            if(dictS.ContainsKey(c)){
                dictS[c]++;
            }else
                dictS[c] = 1;
        }

        foreach(char c in t){
            if(dictT.ContainsKey(c)){
                dictT[c]++;
            }else
                dictT[c] = 1;
        }

    return dictS.Count == dictT.Count && !dictS.Except(dictT).Any();

    }
}
