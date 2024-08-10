public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int high = 0;
        int longestSubString = 0;
        for (int i = 0; i < s.Length; i++)
        {
            HashSet<char> arr = new HashSet<char>();
            high = i;
            while(high < s.Length && !arr.Contains(s[high]))
            {
                arr.Add(s[high]);
                high++;
            }
            longestSubString = Math.Max(longestSubString, (high - i));
        }

        return longestSubString;
    }
}