public class Solution {
    public int MaxVowels(string s, int k) {
        //elmafrod fixed sliding window mushawaha
        //TC: O(n)
        //SC: O(count of vowels)
        int n = s.Length, maxVowels = 0;
        for(int i = 0;i<k;i++){
            if(IsVowel(s[i])){
                maxVowels++;
            }
        }
        int windowVowels = maxVowels;
        for(int i = k;i<n;i++){
            if(IsVowel(s[i])){
                windowVowels++;
            }
            if(IsVowel(s[i-k])){
                windowVowels--;
            }
            maxVowels = Math.Max(maxVowels, windowVowels);
        }
        
        return maxVowels;
    }
    public bool IsVowel(char c){
        HashSet<char> set = new HashSet<char>(){'a','e','i','o','u'};
        return set.Contains(c);
    }
}