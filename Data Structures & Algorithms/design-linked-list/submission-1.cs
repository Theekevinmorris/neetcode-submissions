public class MyLinkedList {

    private Node head;
    private int size;

    public MyLinkedList() {
        head = null;
        size = 0;
    }
    
    public int Get(int index) {
        Node current = head;

        if (index < 0 || index >= size)
            return -1;

        for (int i = 0; i < index; i++){
            current = current.next;
        }
        return current.val;
    }
    
    public void AddAtHead(int val) {
        Node newHead = new Node(val);
        newHead.next = head;
        head = newHead;
        size++;
    }
    
    public void AddAtTail(int val) {
        Node newTail = new Node(val);

        if(head == null){
            head = newTail;
            size++;
            return;
        }

        Node current = head;
        while(current.next != null){
            current = current.next;
        }

        current.next = newTail;
        size++;
        
    }
    
    public void AddAtIndex(int index, int val) {
        if (index < 0 || index > size)
            return;

        if (index == size){
            AddAtTail(val);
            return;
        }

        if (index == 0){
            AddAtHead(val);
            return;
        }


        Node newNode = new Node(val);
        Node prevNode = head;
        
        for(int i = 0; i < index - 1; i ++){
            prevNode = prevNode.next;
        }

        Node nextNode = prevNode.next;
        prevNode.next = newNode;
        newNode.next = nextNode;
        size++;

    }
    
    public void DeleteAtIndex(int index) {
        if(index < 0 || index >= size){
            return;
        }
        
        if(index == 0){
            head = head.next;
            size--;
            return;
        }

        Node current = head;

        for(int i = 0; i < index -1;i++){
            current = current.next;
        }

        current.next = current.next.next;
        size--;

    }
}

public class Node{
    public int val;
    public Node next;

    public Node(int val){
        this.val = val;
        this.next = null;
    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */