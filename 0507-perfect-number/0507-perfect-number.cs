public class Solution {
    public bool CheckPerfectNumber(int num) {
        if(num<=1) return false;
        int sum = 0;
        for(int i = 1;i<num;i++){
            if(num%i == 0){
                sum = sum+i;
            }
        }
        return sum == num;
    }
}