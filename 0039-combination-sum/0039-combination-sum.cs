public class Solution {
    IList<IList<int>> ans = new List<IList<int>>();
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {       
        findCombinationSum(ref candidates, target, 0 , new List<int>() );
        return ans;
    }
    void findCombinationSum(ref int[] cand, int target, int idx, List<int> ds){
        if(idx == cand.Length){
            if(target == 0) ans.Add(new List<int>(ds));
            return;
        }
        if(cand[idx] <= target){
            ds.Add(cand[idx]);
            findCombinationSum(ref cand, target - cand[idx], idx, ds);
            ds.RemoveAt(ds.Count - 1);
        }
        findCombinationSum(ref cand, target, idx + 1,ds);
    }
}