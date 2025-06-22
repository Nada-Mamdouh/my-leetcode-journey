public class Solution {
    public int MostWordsFound(string[] sentences) {
        int maxCount = sentences[0].Split(" ").Length;
        for(int i = 1;i<sentences.Length;i++){
            int len = sentences[i].Split(" ").Length;
            maxCount = Math.Max(maxCount, len);
        }
        return maxCount;
    }
}