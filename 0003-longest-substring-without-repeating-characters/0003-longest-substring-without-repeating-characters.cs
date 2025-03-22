public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int[] arr = new int[256];
        for(int i = 0;i<arr.Length;i++){
            arr[i] = -1;
        }
        int l = 0, r = 0, maxLen = 0, n = s.Length;
        while(r < n){
            if(arr[s[r]] != -1){
                if(arr[s[r]] >= l){
                    l = arr[s[r]] + 1;
                }
            }
            int length = r - l + 1;
            maxLen = Math.Max(maxLen, length);
            arr[s[r]] = r;
            r++;
        }
        return maxLen;
    }
}