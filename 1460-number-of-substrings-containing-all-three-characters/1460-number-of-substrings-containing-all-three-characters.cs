public class Solution {
    public int NumberOfSubstrings(string s) {
        int count = 0;
        int left = 0;
        int[] charCounts = new int[3];
        
        for (int right = 0; right < s.Length; right++) {
            char currentChar = s[right];
            charCounts[currentChar - 'a']++;
            
            while (charCounts[0] > 0 && charCounts[1] > 0 && charCounts[2] > 0) {
                count += s.Length - right;
                char leftChar = s[left];
                charCounts[leftChar - 'a']--;
                left++;
            }
        }
        
        return count;
    }
}