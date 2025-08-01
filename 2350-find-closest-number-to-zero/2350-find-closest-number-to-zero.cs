public class Solution {
    public int FindClosestNumber(int[] nums) {
        int closest = nums[0];
        for(int i = 1;i<nums.Length;i++){
            int num = nums[i];

            int absnum = Math.Abs(num);
            int absclosest = Math.Abs(closest);

            if (absnum < absclosest || (absnum == absclosest && num > closest)) {
                closest = num;
            }
        }
        return closest;
    }
}