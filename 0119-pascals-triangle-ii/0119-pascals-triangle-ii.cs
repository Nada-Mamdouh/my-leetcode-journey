public class Solution {
    public IList<int> GetRow(int rowIndex) {
        IList<int> ans = new List<int>();
        Dictionary<(int, int), int> memo = new Dictionary<(int,int), int>();
        for(int j = 0; j<=rowIndex;j++){
            int val = calcValue(rowIndex, j, memo);
            ans.Add(val);
        }
        return ans;
    }
    public int calcValue(int i , int j, Dictionary<(int, int), int> memo){
        if(memo.ContainsKey((i,j))) return memo[(i,j)];
        int res;
        if(j == 0 || i == j) {
            res = 1;
        }else{
            res = calcValue(i - 1, j - 1, memo) + calcValue(i - 1, j, memo);
        }
        memo.Add((i,j),res);
        return res;
    }
}