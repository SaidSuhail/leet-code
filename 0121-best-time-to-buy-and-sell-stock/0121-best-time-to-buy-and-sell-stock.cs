public class Solution {
    public int MaxProfit(int[] prices) {
        int minprice = prices[0];
        int maxprice = 0;
        for(int i = 1;i<prices.Length;i++){
            if(prices[i]<minprice){
                minprice  = prices[i];
            }else{
                int profit = prices[i] - minprice;
                if(profit>maxprice){
                    maxprice = profit;
                }
            }
        }
        return maxprice;
    }
}