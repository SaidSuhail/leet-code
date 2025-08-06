public class Solution {
    public int MinOperations(int[] nums, int k) {
        var sum = nums.Sum();
        if(sum%k == 0)
        return 0;
        else
        return sum%k;
    }
}