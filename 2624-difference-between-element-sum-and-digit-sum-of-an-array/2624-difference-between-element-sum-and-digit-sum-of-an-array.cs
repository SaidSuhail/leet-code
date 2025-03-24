public class Solution {
    public int DifferenceOfSum(int[] nums) {
        int a = nums.Sum();
        int b = nums.SelectMany(num=>num.ToString().Select(c=>c-'0')).Sum();
        return a-b;
    }
}