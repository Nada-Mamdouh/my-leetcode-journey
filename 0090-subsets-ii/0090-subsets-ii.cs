public class Solution {
    IList<IList<int>> ans = new List<IList<int>>();
    public IList<IList<int>> SubsetsWithDup(int[] nums) {
        //1- sort 
        Array.Sort(nums);
        //2- find subsets
        FindSubSets(ref nums, 0, new List<int>());
        return ans;
    }
    void FindSubSets(ref int[] nums, int idx, List<int> ds){
        //3- add subsets 
        ans.Add(new List<int>(ds));
        for(int i = idx;i<nums.Length;i++){
            //4- check for duplicates on the same recursion level
            if(i > idx && nums[i] == nums[i-1]) continue;

            //5- pick 
            ds.Add(nums[i]);
            FindSubSets(ref nums, i + 1, ds);
            //6- not pick 
            ds.RemoveAt(ds.Count - 1);
            
        }
    }

}