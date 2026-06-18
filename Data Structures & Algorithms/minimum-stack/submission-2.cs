public class MinStack {

    private Stack<int> _stack = new Stack<int>();
    private Stack<int> _minStack = new Stack<int>();

    public MinStack() {
        
    }
    
    public void Push(int val) {
        _stack.Push(val);
        int prevMin = _minStack.Count == 0 ? int.MaxValue : _minStack.Peek();
        _minStack.Push(Math.Min(prevMin, val));
    }
    
    public void Pop() {
        _stack.Pop();
        _minStack.Pop();
    }
    
    public int Top() {
      return _stack.Peek();
    }
    
    public int GetMin() {
        return _minStack.Peek();
    }
}
