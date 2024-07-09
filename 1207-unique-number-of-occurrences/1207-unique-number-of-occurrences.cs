public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        HashSet<int> counts = new HashSet<int>();
        for(int i = 0;i<arr.Length;i++){
            if(!dict.ContainsKey(arr[i])){
                dict.Add(arr[i],1);
            }else{
                dict[arr[i]]++;
            }
        }
        foreach(var kvp in dict){
            if(counts.Contains(kvp.Value)){
                return false;
            }
            counts.Add(kvp.Value);
        }
        return true;
    }
}