public class Solution {
    public bool IsPerfectSquare(int num) {
        double square = Math.Sqrt(num);
        int actualsquare = (int)square;
        if(actualsquare*actualsquare == num)
        return true;
        else
        return false;
    }
}