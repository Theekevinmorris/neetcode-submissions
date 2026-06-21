public class KthLargest {

    PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
    int _k;

    public KthLargest(int k, int[] nums) {
        foreach(int n in nums){
            pq.Enqueue(n,n);
        }

        while(pq.Count > k){
            pq.Dequeue();
        }
    }
    
    public int Add(int val) {
        if(val > pq.Peek()){
            pq.Dequeue();
            pq.Enqueue(val,val);
        }

        return pq.Peek();
    }
}
