class Solution {
public:
    int distributeCandies(vector<int>& candyType) {
        unordered_map<int,int> candies; int edible = candyType.size() / 2;
        for(int i = 0;i<candyType.size();i++){
            if(candies.find(candyType[i]) != candies.end()){
                candies[candyType[i]]++;
            }else{
                candies[candyType[i]] = 1;
            }
        }
        if(candies.size() > edible) return edible;
        return candies.size();

    }
};