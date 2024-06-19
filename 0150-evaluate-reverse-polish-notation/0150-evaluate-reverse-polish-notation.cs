public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> tokenStack = new Stack<int>();
        
        for(int i = 0;i<tokens.Length;i++){
            if(tokens[i] == "+" || tokens[i] == "-" || 
               tokens[i] == "/"|| tokens[i] == "*" ){
                int num1 = tokenStack.Pop();
                int num2 = tokenStack.Pop();
                int res = 0;
                switch(tokens[i]){
                    case "+":
                        tokenStack.Push(num1 + num2);
                        break;
                    case "-":
                        tokenStack.Push(num2 - num1);
                        break;
                    case "*":
                        tokenStack.Push(num1 * num2);
                        break;
                    case "/":
                        tokenStack.Push(num2 / num1);
                        break;
                }
            }else{
                tokenStack.Push(int.Parse(tokens[i]));
            }
        }
        return tokenStack.Pop();
    }
}