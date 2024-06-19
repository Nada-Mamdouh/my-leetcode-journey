public class Solution {
    public bool IsValid(string s) {
        Dictionary<char,char> paras = new Dictionary<char, char>(){
            {'(',')'},
            {'{','}'},
            {'[',']'}
        };
        Stack<char> validParas = new Stack<char>();
        char tos = ' ';
        foreach(char c in s){
            if(paras.ContainsKey(c)){
                validParas.Push(c);
            }else if(paras.ContainsKey(tos) && c == paras[tos]){
                validParas.Pop();
            }else{
                return false;
            }
            tos = validParas.Count > 0 ? validParas.Peek():' ';
            
        }
        if(validParas.Count == 0) return true;
        return false;
    }
}