public class Solution {
    public bool IsValid(string word) {
         word = word.ToLower();
        if(word.Length<3) return false;

        if(!word.All(char.IsLetterOrDigit)) return false;

        var vowels = "aeiou";
        if(!word.Any(a=>vowels.Contains(a))) return false;

        if(!word.Any(a=>char.IsLetter(a) && !vowels.Contains(a))) return false;

        return true;
    }
}