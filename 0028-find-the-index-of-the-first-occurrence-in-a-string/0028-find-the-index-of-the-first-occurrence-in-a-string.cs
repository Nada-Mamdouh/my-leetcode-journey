public class Solution {
    public int StrStr(string haystack, string needle) {
        //TC: M(length of haystack)/N(length of needle)
        //SC: O(1)
        if(needle.Length > haystack.Length) return -1;

        int i = 0, n = needle.Length;
        while(i < haystack.Length - n + 1){
            string tmp = haystack.Substring(i,n);
            if(tmp == needle) return i;
            i++;
        }
        return -1;
    }
}