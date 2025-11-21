public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        var result = new List<IList<int>>();
        Permute(nums, 0, result, new List<int>());
        return result;
    }

    private void Permute(int[] nums, int index, List<IList<int>> result, List<int> current)
    {
        if (index == nums.Length)
        {
            result.Add(current.ToList());
            return;
        }

        var num = nums[index];
        var count = current.Count;
        for (var i = 0; i <= count; i++)
        {
            current.Insert(i, num);
            Permute(nums, index+1, result, current);
            current.RemoveAt(i);
        }
    }
}