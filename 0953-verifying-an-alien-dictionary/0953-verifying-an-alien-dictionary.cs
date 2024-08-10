public class Solution {
    public bool IsAlienSorted(string[] words, string order) {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        Dictionary<(int, int), string> wordsDict = 
            new Dictionary<(int, int), string>();
        for(int i = 0;i<26;i++){
            dict.Add(order[i], i);
        }

        for(int j = 0;j< words.Length-1;j++){
            string word1 = words[j];
            string word2 = words[j+1];
            
            int min_Len = Math.Min(word1.Length, word2.Length);
            for(int g = 0;g<min_Len;g++){
                if(dict[word1[g]] < dict[word2[g]]){
                    
                    break;
                }else if(dict[word1[g]] > dict[word2[g]]){
                    return false; 
                }
            }
            
            if(word1.Length > word2.Length && word1.StartsWith(word2)){
                return false;
            }

        }
        return true;
    }
}