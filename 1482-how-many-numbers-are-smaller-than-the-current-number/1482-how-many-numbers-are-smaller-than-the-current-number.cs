public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        int n = nums.Length;
        int[]result = new int[n];
        for(int i = 0;i<n;i++){
            int count = 0;
            for(int j = 0;j<n;j++){
               if(nums[j] < nums[i]){
                    count++;
                }
            }
            result[i] = count;
        }    
        return result;
    }
}