public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        if(nums.Length < k) return [];

        var dict = new Dictionary<int,int>();
        var pqueue = new PriorityQueue<int,int>();


        for(int i = 0; i < nums.Length; i++){
            if(dict.ContainsKey(nums[i])){
                dict[nums[i]]++;
            }else{
                dict[nums[i]] = 1;
            }
        }

        foreach(var j in dict){
            if (pqueue.Count < k){
                pqueue.Enqueue(j.Key, j.Value);
            }else{
                pqueue.TryPeek(out int element, out int priority);
                if (priority < j.Value){
                    pqueue.Dequeue();
                    pqueue.Enqueue(j.Key, j.Value);
                }
            }
        }

        var result = new List<int>();
        while (pqueue.Count > 0)
        {
            result.Add(pqueue.Dequeue());
        }
        return result.ToArray();

    }
}
