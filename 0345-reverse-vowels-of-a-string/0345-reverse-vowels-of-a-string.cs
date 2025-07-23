public class Solution {
    public string ReverseVowels(string s) {
        string vowels = "aeiouAEIOU";
        string found = "";
        foreach(char c in s)
        {
            if(vowels.Contains(c))
            found = found+c;
        }
   
    string reversed = new string(found.Reverse().ToArray());
    
    string result = "";
    int j = 0;

    foreach(char c in s){
        if(vowels.Contains(c)){
            result = result+reversed[j];
            j++;
        }else{
            result = result+c;
        }
    }
return result;
} 
}

