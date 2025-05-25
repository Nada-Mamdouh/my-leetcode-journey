public class Solution {
    public bool JudgeCircle(string moves) {
        (int, int) starter = (0,0);
        for(int i = 0;i<moves.Length;i++){
            switch(moves[i]){
                case 'U':
                starter.Item2 += 1;
                break;
                case 'D':
                starter.Item2 -= 1;
                break;
                case 'L':
                starter.Item1 -= 1;
                break;
                case 'R':
                starter.Item1 += 1;
                break;
            }
        }
        if(starter.Item1 == 0 && starter.Item2 == 0) return true;
        return false;
    }
}