public class Solution {
    public int DaysBetweenDates(string date1, string date2) {
        var first = DateTime.Parse(date1);
        var second = DateTime.Parse(date2);
        return Math.Abs((first-second).Days);
    }
}