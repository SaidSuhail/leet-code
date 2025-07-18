public class Solution {
    public void ReverseString(char[] s) {
         string reversed = "";
        for(int i = s.Length-1;i>=0;i--){
            reversed = reversed+s[i];
        }
        for(int i = 0;i<s.Length;i++){
            s[i] = reversed[i];
        }
    }
}