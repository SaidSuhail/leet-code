public class Solution {
    public int[] RunningSum(int[] nums) {
        int n = nums.Length;
        for(int i = 1;i<n;i++){
            nums[i] = nums[i] + nums[i-1];
        }
        return nums;
    }
}