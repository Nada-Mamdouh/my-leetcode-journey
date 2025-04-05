public class Solution {
    public bool IsStrictlyPalindromic(int n) {
        //SC: O(3logn)
        //TC: O(2logn) + O(logn) -> O(3logn)
        string bin = getBinaryRepresentation(n);
        int j = bin.Length - 1;
        for(int i = 0;i<bin.Length;i++){
            if(bin[i] != bin[j]) return false;
            j--;
        }
        return false;
    }
    string getBinaryRepresentation(int n){
        Stack<char> st = new();
        while(n >= 1){
            int remainder = n % 2;
            char rep = remainder == 1 ? '1':'0';
            st.Push(rep);
            n /= 2;
        }
        char[] arr = new char[st.Count];
        int i = 0;
        while(st.Count > 0){
            arr[i++] = st.Pop();
        }
        return new String(arr);
    }
    
}