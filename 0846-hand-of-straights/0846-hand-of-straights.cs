public class Solution {
    public bool IsNStraightHand(int[] hand, int groupSize) {
        if(hand.Length % groupSize > 0) return false;
        Dictionary<int, int> dict = 
            new Dictionary<int, int>();
        //Array.Sort(hand);
        for(int i = 0;i<hand.Length;i++){
            if(dict.ContainsKey(hand[i])) dict[hand[i]]++;
            else{
                dict.Add(hand[i], 1);
            }
        }
        var sorteDkeys = dict.Keys.ToList();
        sorteDkeys.Sort();
        
        foreach(var curr in sorteDkeys){
            int count = dict[curr];
            
            if(count > 0){
                for(int i = 0;i<groupSize;i++){
                    var nextCard = curr + i;
                    if(!dict.ContainsKey(nextCard) 
                       || dict[nextCard] < count) return false;
                    dict[nextCard] -= count;
                }
                
            }
            
        }
        return true;
    }
}