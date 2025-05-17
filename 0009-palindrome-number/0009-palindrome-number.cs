public class Solution {
    public bool IsPalindrome(int x) {
        string nums = x.ToString();
        char[]c = nums.ToCharArray();
        Array.Reverse(c);
        string newone  = new string(c);
        return nums == newone;
    }
}