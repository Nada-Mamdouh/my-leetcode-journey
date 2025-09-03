public class Solution {
    public int[] RecoverOrder(int[] order, int[] friends) {
        List<int> ans = new List<int>();
        foreach(var item in order){
            if(ans.Count == friends.Length) break;
            int index = binarySearch(item, ref friends);
            if(index < 0) continue;
            ans.Add(friends[index]);
        }
        return ans.ToArray();
    }
    int binarySearch(int item, ref int[] friends){
        int left = 0, right = friends.Length - 1;
        while(left <= right){
            int mid = (left + right)/2;
            if(friends[mid] == item) return mid;
            else if(friends[mid] > item) right = mid - 1;
            else left = mid + 1;
        }
        return -1;
    }
}