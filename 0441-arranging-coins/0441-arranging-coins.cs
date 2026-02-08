public class Solution {
    public int ArrangeCoins(int n) {
      int  i = 0;
      while (n>i){
        i++;
        n = n-i;
      }  
      return i;
    }
}