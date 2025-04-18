public class Solution {
    public bool LemonadeChange(int[] bills) {
        int fives = 0, tens = 0;
        for(int i = 0;i<bills.Length;i++){
            switch(bills[i]){
                case 20:
                  if(tens > 0 && fives > 0) {
                    tens--;
                    fives--;
                  }else if(fives >= 3) {
                    fives -= 3;
                  }else return false;
                break;
                case 10:
                  tens++;
                  if(fives > 0) fives--;
                  else return false;
                break;
                default:
                   fives++;
                break;
            }
        }
        return true;
    }
}