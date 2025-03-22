public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] x = s.ToCharArray();
        char[] y = t.ToCharArray();
         Array.Sort(x);
         Array.Sort(y);
       return new string(x) == new string(y);
    }
}