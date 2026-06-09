class Solution {
     isValid(s) {
        if(s.length % 2 != 0){
            return false;
        }
        let stack = [];
        let lastItem;
        for(let char in s){
            if(char == '[' || char =='{' || char == '('){
                stack.push(s);
            }

            if (char == ']'){
               lastItem = stack.pop(); 
               if(lastItem != '['){
                    return false;
               }
            }

            if (char == '}'){
               if(lastItem != '{'){
                    return false;    
               }
            }

            if (char == ')'){
               if(lastItem != '()'){
                    return false;
               }
            }            
        }
        return true;
        
    }
}
