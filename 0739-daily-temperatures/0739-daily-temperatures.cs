public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var answer = new int[temperatures.Length];
        var hottest = 0;
        for (var i = temperatures.Length - 1; i >= 0; i--)
        {
            var cur = temperatures[i];
            if (cur >= hottest)
            {
                hottest = cur;
                continue;
            }

            var days = 1;
            while (temperatures[i + days] <= cur)
            {
                days += answer[i + days];
            }
            answer[i] = days;
        }

        return answer;
    }
}