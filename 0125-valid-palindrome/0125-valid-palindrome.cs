public class Solution {
    public bool IsPalindrome(string s) {
        //chars 97 - 122 - nums: 48 - 57
        int start = 0, end = s.Length - 1;
        string sLowered = s.ToLower();
        while(start < end){
            while(start < s.Length-1 && !isAlphaNumeric(sLowered[start]))start++;
            while(end > 1 && !isAlphaNumeric(sLowered[end])) end--;
            if(isAlphaNumeric(sLowered[start]) && isAlphaNumeric(sLowered[end]) && sLowered[start] != sLowered[end]) return false;
            start++;
            end--;
        }
        return true;
    }
    bool isAlphaNumeric(char c) => (c >= 48 && c <= 57) || (c >= 97 && c <= 122);
}