public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        IList<bool> ans = new List<bool>();
        int maxVal = int.MinValue;
        for(int i = 0;i<candies.Length;i++){
            if(candies[i] > maxVal) maxVal = candies[i];
        }
        for(int i = 0;i<candies.Length;i++){
            if(candies[i] + extraCandies >= maxVal) ans.Add(true);
            else ans.Add(false);
        }
        return ans;
    }
}