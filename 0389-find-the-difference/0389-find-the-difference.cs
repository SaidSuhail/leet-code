public class Solution {
    public char FindTheDifference(string s, string t) {
        int answer = 0;

        foreach(char i in t){
            answer = answer+i;
        }
        
        foreach(char i in s){
            answer = answer-i;
        }

        return (char)answer;
    }
}