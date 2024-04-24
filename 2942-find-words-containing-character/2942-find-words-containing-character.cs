public class Solution {
    public IList<int> FindWordsContaining(string[] words, char x) {
        List<int> indeces = new List<int>();
        for(int i = 0;i<words.Length;i++){
            if(words[i].IndexOf(x) != -1) indeces.Add(i);
        }
        return indeces;
    }
}