public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices.Length == 0) return 0;

        int maxProfit = 0;
        int buyDay = 0;

        for(int i = 0; i < prices.Length; i++){
            if(prices[i] < prices[buyDay]){
                buyDay = i;
                continue;
            }

            maxProfit = Math.Max(maxProfit, prices[i] - prices[buyDay]);

        }

        return maxProfit;

    }
}
