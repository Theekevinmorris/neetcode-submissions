public class Solution {
    public int LastStoneWeight(int[] stones) {
        if (stones.Length == 1)
            return stones[0];

        var items = stones.Select(n => (n, -n));
        PriorityQueue<int,int> pq = new PriorityQueue<int,int>(items);

        while(pq.Count > 1){
            int largest = pq.Dequeue();
            int secondLargest = pq.Dequeue();

            if(largest > secondLargest){
                int newValue = largest - secondLargest;
                pq.Enqueue(newValue, -newValue);
            }
        }

        return pq.Count == 1 ? pq.Peek() : 0;


    }
}
