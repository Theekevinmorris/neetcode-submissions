class Solution {
    isPalindrome(s) {
        const newString = s.replace(/[^a-zA-Z0-9]/g, '').toLowerCase();

        let lpos = 0;
        let rpos = newString.length - 1;

        while(lpos != rpos){
            if(newString[lpos] == newString[rpos]){
                lpos += 1;
                rpos -= 1;
            }else{
                return false;
            }
        }

        return true;
    }
}
