
public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary <int,int> frequencyMap = 
            new Dictionary <int,int>();
        List<KeyValuePair<int,int>> countList = new List<KeyValuePair<int,int>>();
        
       foreach(var num in nums){
           if(!frequencyMap.ContainsKey(num)){
               frequencyMap.Add(num, 1);
           }else{
               frequencyMap[num]++;
           }
       }
        foreach(var kvp in frequencyMap){
            countList.Add(kvp);
        }
        
        //Build Max Heap:
        BuildMaxHeap(ref countList);
        
        int[] res = new int[k];
        for(int i = 0;i<k;i++){
            int maxCount = Dequeue(ref countList).Key;
            res[i] = maxCount;
        }
        return res;
    }
    public static void BuildMaxHeap(ref List<KeyValuePair<int,int>>  dict){
        for(int i = dict.Count / 2 - 1; i >= 0;i--){
            HeapifyDown(i, ref dict);
        }
    }
    public static void HeapifyDown(int idx, ref List<KeyValuePair<int,int>> dict){
        int last = dict.Count -1;
        while(true){
            int left = idx * 2 + 1;
            if(left > last) break;
            int maxIdx = left;
            
            int right = left + 1;
            if(right <= last && dict[right].Value > dict[maxIdx].Value)             {
                maxIdx = right;
            }
            
            if(dict[idx].Value > dict[maxIdx].Value) break;
            Swap(idx, maxIdx, ref dict);
            idx = maxIdx;
        }
        
    }
    public static void Swap(int idx1,int idx2, ref List<KeyValuePair<int,int>> dict){
        var tmp = dict[idx1];
        dict[idx1] = dict[idx2];
        dict[idx2] = tmp;
    }
    public static KeyValuePair<int,int>  Dequeue(ref List<KeyValuePair<int,int>>  counts){
        var root = counts[0];
        counts[0] = counts[counts.Count - 1];
        counts.RemoveAt(counts.Count - 1);
        HeapifyDown(0, ref counts);
        return root;
    }
}