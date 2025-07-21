public class Solution {
    public string MakeFancyString(string s) {
        if(s.Length<3) return s;

        
        StringBuilder result = new StringBuilder();
        int count = 1;


        for (int i = 0; i < s.Length; i++) {
            if (i > 0 && s[i] == s[i - 1]) {
                count++;
            } else {
                count = 1;
            }
            if (count < 3) {
                result = result.Append(s[i]);
            }
    }
    return result.ToString();
}
}