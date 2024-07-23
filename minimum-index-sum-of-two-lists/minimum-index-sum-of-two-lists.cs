public class Solution {
    public string[] FindRestaurant(string[] list1, string[] list2) {
        Dictionary<string,int> dict1 = new Dictionary<string, int>();
        Dictionary<string,int> dict2 = new Dictionary<string, int>();
        
        for(int i = 0;i<list1.Count();i++){
            if(!dict1.ContainsKey(list1[i])){
                dict1.Add(list1[i],i);
            }
        }
        
        for(int j = 0;j<list2.Count();j++){
            if(!dict2.ContainsKey(list2[j])){
                dict2.Add(list2[j],j);
            }
        }
        
        int min_index_sums = int.MaxValue;
        foreach(var item in dict1){
            if(dict2.ContainsKey(item.Key)){
                int sum = dict1[item.Key] + dict2[item.Key];
                if(sum <= min_index_sums){
                    min_index_sums = sum;
                }
            }
        }
        List<string> res = new List<string>();
        foreach(var item in dict1){
            if(dict2.ContainsKey(item.Key)){
                int sum2 = dict1[item.Key] + dict2[item.Key];
                if(sum2 == min_index_sums){
                    res.Add(item.Key);
                }
            }
        }
        return res.ToArray();
    }
}