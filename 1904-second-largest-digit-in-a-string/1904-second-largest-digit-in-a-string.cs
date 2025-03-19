public class Solution {
    public int SecondHighest(string s) {
       var second =  s.Where(char.IsDigit)
        .Select(c=>c -'0')
        .Distinct()
        .OrderByDescending(x=>x)
        .Skip(1)
       .FirstOrDefault(-1);
       return second;
    }
}