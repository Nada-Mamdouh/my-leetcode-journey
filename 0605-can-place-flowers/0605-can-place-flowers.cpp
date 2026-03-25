class Solution {
public:
    bool canPlaceFlowers(vector<int>& flowerbed, int n) {
        int size = flowerbed.size();
        if(size == 1 && flowerbed[0] == 0){
            if(n == 1 || n == 0) return true;
            else return false;
        }else if(size == 1 && flowerbed[0] == 1){
            if(n > 0) return false;
            else return true;
        } 
        for(int i = 0;i<size;i++){
            if((flowerbed[i] == 0 && i == 0 && flowerbed[i+1] == 0) 
            || (flowerbed[i] == 0 && i == size-1 && flowerbed[i-1] == 0)
            || (i > 0 && i < size -1 && flowerbed[i] == 0 && flowerbed[i-1] == 0 && flowerbed[i+1] == 0))
            {
                n--;
                flowerbed[i] = 1;
            }
            
        }
        if(n <= 0) return true;
        return false;
    }
};