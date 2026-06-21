public class KthLargest {

    private PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
    private int _k;

    public KthLargest(int k, int[] nums) {
        foreach(int n in nums){
            pq.Enqueue(n,n);
        }

        while(pq.Count > _k){
            pq.Dequeue();
        }
    }
    
    public int Add(int val) {
        pq.Enqueue(val,val);

        if (pq.Count > _k){
            pq.Dequeue();
        }

        return pq.Peek();
    }
}
