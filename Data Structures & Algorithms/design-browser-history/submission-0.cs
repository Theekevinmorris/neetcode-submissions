public class BrowserHistory {

    private LinkedList<string> history = new LinkedList<string>();
    private LinkedListNode<string> current;

    public BrowserHistory(string homepage) {
        history.AddLast(homepage);
        current = history.First;
    }
    
    public void Visit(string url) {
        while(current.Next != null){
            history.Remove(current.Next);
        }
        history.AddLast(url);
        current = history.Last;
    }
    
    public string Back(int steps) {
        for(int i = 0; i < steps; i++){
            if (current.Previous == null)
                return current.Value;
            
            current = current.Previous;
        }
        return current.Value;
    }
    
    public string Forward(int steps) {
        for(int i = 0; i < steps; i++){
            if(current.Next == null)
                return current.Value;
            current = current.Next;
        }
        return current.Value;
    }
}

/**
 * Your BrowserHistory object will be instantiated and called as such:
 * BrowserHistory obj = new BrowserHistory(homepage);
 * obj.Visit(url);
 * string param_2 = obj.Back(steps);
 * string param_3 = obj.Forward(steps);



 */