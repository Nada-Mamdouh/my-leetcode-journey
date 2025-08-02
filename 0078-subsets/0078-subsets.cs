public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        var result = new List<IList<int>>();
        Backtrack(nums,0,new List<int>(),result);
        return result;
    }
    void Backtrack(int[] nums, int start, List<int> current, List<IList<int>> result) {
        // Add a copy of the current subset
        result.Add(new List<int>(current));

        // Explore further by including nums[i]
        for (int i = start; i < nums.Length; i++) {
            current.Add(nums[i]); // choose
            Backtrack(nums, i + 1, current, result); // explore
            current.RemoveAt(current.Count - 1); // un-choose (backtrack)
        }
    }
}