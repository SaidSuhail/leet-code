public class Solution {
    public bool CheckIfPangram(string sentence) {
        return sentence.Where(char.IsLetter)
        .Distinct().Count() == 26;
    }
}