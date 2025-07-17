public class Solution {
    public int StrStr(string haystack, string needle) {
        int m = haystack.Length;
        int n = needle.Length;

        if(n == 0)return 0;

        for(int i = 0;i <= m-n;i++){
            int j = 0;
            while(j<n && haystack[i+j] ==  needle[j]){
                j++;
            } 
            if(j == n)
                return i;
            
        }
         return -1;
    }
}