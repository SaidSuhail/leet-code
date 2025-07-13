public class Solution {
    public int DifferenceOfSums(int n, int m) {
        int number = 0;
        for(int i = 1;i<=n;i++){
            if(i%m != 0){
                number = number+i;
            }else{
                number = number-i;
            }
        }
        return number;
    }
}