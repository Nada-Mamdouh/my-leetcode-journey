* Solved on 22nd June, 2024
* The trick is to use 2 stacks, 1 to traverse the tree and the other to process values.
1- Initialize 2 stacks: s1, s2
2- push root to first stack.
3- loop over first stack while it's not empty.
4- inside the loop pop first element.
5- push it to s2
6- push the node to the left if exists
7- push the node to the right if exists.
8- out of the loop
9- loop over the second stack s2.
10- pop element
11- and process it.
```
Stack<TreeNode> s1 = new Stack<TreeNode>();
Stack<TreeNode> s2 = new Stack<TreeNode>();
IList<int> lst = new List<int>();
if(root == null) return lst;
s1.Push(root);
while(s1.Count > 0){
TreeNode current = s1.Pop();
s2.Push(current);
if(current.left != null){
s1.Push(current.left);
}
if(current.right != null){
s1.Push(current.right);
}
}
while(s2.Count > 0){
TreeNode current = s2.Pop();
lst.Add(current.val);
}
return lst;
```
​
* New solution using recursion for Manara on 17th August, 2024: