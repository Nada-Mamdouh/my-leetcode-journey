public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        for(int i = 0; i<flowerbed.Length;i++){
            if(conditionMet(ref flowerbed, i)) {
                if(n == 0) break;
                n--;
                flowerbed[i] = 1;
            }
        }
        return n == 0;
    }
    bool conditionMet(ref int[] flowerbed,int i){
        if(flowerbed[i] == 0){
            if(flowerbed.Length == 1) return true;
            else if(i == 0 && flowerbed[i+1] == 0) return true;
            else if(i == flowerbed.Length - 1 && flowerbed[i-1] == 0) return true;
            else if(i > 0 && i < flowerbed.Length && flowerbed[i-1] == 0 && flowerbed[i+1] == 0) return true;
        }
        return false;
    }
}