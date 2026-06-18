public class MinStack {

    private Stack<int> _stack = new Stack<int>();
    private Stack<int> _minStack = new Stack<int>();
    private int currentMin = int.MaxValue;

    public MinStack() {
        
    }
    
    public void Push(int val) {
        _stack.Push(val);
        _minStack.Push(Math.Min(currentMin,val));
        currentMin = _minStack.Peek();
    }
    
    public void Pop() {
        _stack.Pop();
        _minStack.Pop();
        currentMin = _minStack.Peek();
    }
    
    public int Top() {
      return _stack.Peek();
    }
    
    public int GetMin() {
        return _minStack.Peek();
    }
}
