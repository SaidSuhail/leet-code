public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int count = 0;
        for(int i = 0;i<s.Length;i++){
            HashSet<char>set = new HashSet<char>();    
             int currentcount = 0;
            for(int j = i;j<s.Length;j++){
                if(set.Contains(s[j])){
                    break;
                }
                set.Add(s[j]);
                currentcount++;
            }
            if(currentcount>count){
                count = currentcount;
            }
        }
        return count;
    }
}