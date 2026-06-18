public class Solution {
    public bool IsValid(string s) {
        if(s.Length % 2  > 0)
            return false;
        var stack = new Stack<char>();
        foreach(char c in s){
            if (c == '{' || c == '(' || c == '['){
                stack.Push(c);
            }else{
                if(c == '}' && stack.Peek() == '{'){
                    stack.Pop();
                }else if(c == ']' && stack.Peek() == '['){
                    stack.Pop();
                }else if(c == ')' && stack.Peek() == '('){
                    stack.Pop();
                }else{
                    return false;
                }
            }
        }
        return stack.Count == 0;
    }
}