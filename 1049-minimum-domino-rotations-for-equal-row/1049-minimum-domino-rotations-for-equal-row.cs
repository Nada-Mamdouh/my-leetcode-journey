public class Solution {
    public int MinDominoRotations(int[] tops, int[] bottoms) {
        int len = tops.Length, maxTop = 0, maxBott = 0,maxTopKey = 1, maxBottKey = 1, ans = 0;
        Dictionary<int, int> topsDict = new();
        Dictionary<int, int> bottomsDict = new();
        for(int i = 0;i<len;i++){
            if(!topsDict.ContainsKey(tops[i])) topsDict.Add(tops[i], 0);
            topsDict[tops[i]]++;
            if(!bottomsDict.ContainsKey(bottoms[i])) bottomsDict.Add(bottoms[i],0);
            bottomsDict[bottoms[i]]++;
        }
        foreach(var ele in topsDict){
            maxTop = Math.Max(maxTop, ele.Value);
        }
        foreach(var ele in bottomsDict){
            maxBott = Math.Max(maxBott, ele.Value);
        }
        maxTopKey = topsDict.LastOrDefault(x => x.Value == maxTop).Key;
        maxBottKey = bottomsDict.LastOrDefault(x => x.Value == maxBott).Key;
        if(topsDict[maxTopKey] + bottomsDict[maxBottKey] < len) return -1;
        if(topsDict[maxTopKey] == bottomsDict[maxBottKey] && topsDict[maxTopKey] == len) return ans;
        if(topsDict[maxTopKey] >= bottomsDict[maxBottKey]){
            int j = 0;
            while(j < len){
                if(tops[j] != maxTopKey && bottoms[j] == maxTopKey){
                    ans++;
                }else if(tops[j] != maxTopKey && bottoms[j] != maxTopKey){
                    return -1;
                }
                j++;
            }
        }else if(topsDict[maxTopKey] < bottomsDict[maxBottKey]){
            int k = 0;
            while(k < len){
                if(bottoms[k] != maxBottKey && tops[k] == maxBottKey){
                    ans++;
                }else if(bottoms[k] != maxBottKey && tops[k] != maxBottKey){
                    return -1;
                }
                k++;
            }
        }
        return ans;
    }
}