public class Solution {
    public int SingleNumber(int[] nums) {
        return nums.GroupBy(x=>x).First(x=>x.Count()<=2).Key;
    }
}