public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        HashSet<char> jewelSet = new HashSet<char>();
        int jewelCount = 0;
        foreach(var c in jewels){
            jewelSet.Add(c);
        }
        for(int i = 0;i<stones.Length;i++){
            if(jewelSet.Contains(stones[i])){
                jewelCount++;
            }
        }
        return jewelCount;
    }
}