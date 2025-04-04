public class Solution {
    public string RemoveStars(string s) {
        Stack<char> st = new Stack<char>();
        for(int i = 0;i<s.Length;i++){
            if(st.Count > 0 && s[i] == '*'){
                st.Pop();
            }
            if(s[i] != '*'){
                st.Push(s[i]);
            }
        }
        char[] arr = new char[st.Count];
        int j = st.Count - 1;
        while(st.Count != 0){
            arr[j--] = st.Pop();
        }
        return new String(arr);
    }
}