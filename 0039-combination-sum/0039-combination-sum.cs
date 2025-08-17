public class Solution {
    IList<IList<int>> ans = new List<IList<int>>();
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {       
        findCombination(ref candidates, target, 0, new List<int>());
        return ans;
    }
    void findCombination(ref int[] candidates, int target, int indx , List<int> ds){
        if(indx == candidates.Length){
            if(target == 0) ans.Add(new List<int>(ds));
            return;
        }
        //pick
        if(candidates[indx] <= target){
            ds.Add(candidates[indx]);
            findCombination(ref candidates, target - candidates[indx], indx, ds);
            ds.RemoveAt(ds.Count - 1);
        }
        //not pick
        findCombination(ref candidates, target, indx + 1, ds);
    }
    
}