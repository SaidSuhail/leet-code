public class Solution {
    public string AddStrings(string num1, string num2) {
         BigInteger a = BigInteger.Parse(num1);
        BigInteger b = BigInteger.Parse(num2);
        BigInteger result = a + b;
        return result.ToString();
    }
}