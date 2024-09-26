since it's bst try preorder traversal
​
​
6, **2**, 0, 4, 3, 5, **8**, 7, 9
​
6, **2** , 0,** 4**, 3, 5, 8, 7, 9
**2**, **1**
​
check if both p && q less than the root then traverse right,
if both p && q greater than the root then traverse left.
if one value is greater or equal and one is less or equal then the root itself is the lca