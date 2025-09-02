public class Solution {
    public int[] RecoverOrder(int[] order, int[] friends) {
        HashSet<int> set = new HashSet<int>();
        int[] ans = new int[friends.Length];
        for(int i = 0;i<friends.Length;i++){
            set.Add(friends[i]);
        }
        int j = 0;
        for(int i = 0;i<order.Length;i++){
            if(set.Contains(order[i])){
                if(j == friends.Length) break;
                ans[j++] = order[i];
            }
        }
        return ans;

    }
}