public class Solution {
    public int CountPoints(string rings) {
        int rodCount = 0;
        Dictionary<int, HashSet<char>> dict = new();
        for(int i = 0;i<rings.Length - 1 ;i++){
            if(!dict.ContainsKey(rings[i+1])){
                dict.Add(rings[i+1], new HashSet<char>(){rings[i]});
            }else{
                dict[rings[i+1]].Add(rings[i]);
            }
        }
        foreach(var kvp in dict){
            Console.WriteLine(kvp.Key);
            if(kvp.Value.Contains('R') &&
              kvp.Value.Contains('G')  &&
              kvp.Value.Contains('B')) rodCount++;
        }
        return rodCount;
    }
}