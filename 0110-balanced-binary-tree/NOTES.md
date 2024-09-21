* the key to know if a tree is balanced or not is check the heights of subtrees and the whole tree if the difference of all the subtrees and the total tree is less than or equal 1 then it's ***balanced***
* Other wise if the difference is more than 1 then it's ***unbalanced***
* Edge cases: if the tree is empty or has one element it's balanced.
* 1- need to keep a flag if we encountered inside the recursion method any unbalanced subtree then we will set it to false
* 2- in the main method we will check the final height of both left and right subtrees if the difference is <= 1 && flag == true then the result is true else the result is false.