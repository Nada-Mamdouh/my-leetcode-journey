public class Solution {
    public string RemoveKdigits(string num, int k) {
        Stack<char> st = new();
        //Normal traversal
        for(int i = 0;i<num.Length;i++){
            while(st.Count > 0 && k> 0 && st.Peek()-'0' > num[i]-'0'){
                st.Pop();
                k--;
            }
            st.Push(num[i]);
        }
        //If the elements were sorted ascending and no removal happenend
        //Then remove the greatest values from TOS
        while(k > 0 && st.Count > 0){
            st.Pop();
            k--;
        }
        //If all the elements were removed 
        if(st.Count == 0){
            return "0";
        }
        //group characters together
        char[] ans = new char[st.Count];
        int j = 0;
        while(st.Count > 0){
            ans[j++] = st.Pop();
        }
        
        Reverse(ref ans);
        string val = new String(ans);
        for(int i = 0;i<ans.Length;i++){
            if(ans[i] != '0'){
                val = val.Substring(i);
                break;
            }
        }
        return val[0] != '0' && val.Length > 0? val: "0";

    }
    void Reverse(ref char[] arr){
        int i = 0, j = arr.Length -1;
        while(j > i){
            char tmp = arr[i];
            arr[i] = arr[j];
            arr[j] = tmp;
            i++; j--;
        }
    }

}