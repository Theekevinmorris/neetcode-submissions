public class MyStack {
    Queue<int> queue = new Queue<int>();

    public MyStack() {
        
    }
    
    public void Push(int x) {
        queue.Enqueue(x);

        for(int i =0; i < queue.Count -1; i ++){
            queue.Enqueue(queue.Dequeue());
        }
    }
    
    public int Pop() {
        var poppedInt = queue.Dequeue();
        return poppedInt;
    }
    
    public int Top() {
        var topInt = queue.Peek();
        return topInt;
    }
    
    public bool Empty() {
        return queue.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */