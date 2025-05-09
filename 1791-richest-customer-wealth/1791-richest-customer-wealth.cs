public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int maxsum = 0;
        for(int i = 0;i<accounts.Length;i++){
            int currentsum = 0;
            for(int j = 0;j<accounts[i].Length;j++){
                currentsum = currentsum+accounts[i][j];
            }
            if(currentsum>maxsum){
                maxsum = currentsum;
            }
        }
        return maxsum;
    }
}