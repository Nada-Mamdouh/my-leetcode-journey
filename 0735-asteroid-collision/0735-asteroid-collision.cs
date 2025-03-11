public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        Stack<int> st = new Stack<int>();
        for(int i = 0;i<asteroids.Length;i++){
            if(st.Count == 0 || asteroids[i] > 0){
                st.Push(asteroids[i]);
            }else{
                while(asteroids[i] < 0 && st.Count > 0 && st.Peek() > 0 && Math.Abs(asteroids[i]) > st.Peek()){
                    st.Pop();
                }
                if(asteroids[i] < 0 && st.Count > 0 && st.Peek() > 0 && Math.Abs(asteroids[i]) < st.Peek()){
                    continue;
                }else if(asteroids[i] < 0 && st.Count > 0 && st.Peek() > 0 && Math.Abs(asteroids[i]) == st.Peek()){
                    st.Pop();
                }else{
                    st.Push(asteroids[i]);
                }
            }
        }
        int[] ans=new int[st.Count];
        int j = ans.Length -1;
        while(st.Count > 0){
            ans[j--] = st.Pop();
        }
        return ans;
    }
    
}