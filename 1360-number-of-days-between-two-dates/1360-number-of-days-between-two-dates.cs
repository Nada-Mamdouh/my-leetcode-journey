public class Solution {
    public int DaysBetweenDates(string date1, string date2) {
        DateTime d1 = DateTime.Parse(date1);
        DateTime d2 = DateTime.Parse(date2);
        
        return (int)Math.Abs((d1 - d2).TotalDays);
        
    }
}