public class Solution {
    public IList<int> SelfDividingNumbers(int left, int right) {
        List<int>list  = new List<int>();
        for(int i = left;i<=right;i++){
             if (IsSelfDividing(i)) {
                list.Add(i);
             }
            }
            return list;
        }

        private bool IsSelfDividing(int num){
            int original = num;
             while (num > 0) {
            int digit = num % 10;
            if (digit == 0 || original % digit != 0) {
                return false;
            }
            num = num/10;
        }

        return true;
        
    }
}