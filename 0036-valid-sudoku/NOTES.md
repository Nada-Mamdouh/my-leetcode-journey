[Last year notes & code]
//neetcode_solution
/** O(n2), space O(n)
Approach: 1- use hashSet for each column, row and dictionary for the board
2- Board dictionary: key(is the modified 2 indices),
value is the actual value in it.
3- use nested loops to loop over the matrix
4- if any square value is in rowHashSet or columnHashSet or
BoardDictionary return false, anyway update the sets and
dictionary, continue the loop till end
​
finally return true it's a valid sudoko
**/
`
Dictionary<int, HashSet<char>> row = new Dictionary<int, HashSet<char>>();
Dictionary<int, HashSet<char>> col = new Dictionary<int, HashSet<char>>();
Dictionary<(int, int), HashSet<char>> boardDict =
new Dictionary<(int, int), HashSet<char>>();
​
for(int r = 0; r<9; r++){
row[r] = new HashSet<char>();
for(int c = 0; c < 9; c++){
if(!col.ContainsKey(c)) col[c] = new HashSet<char>();
if(!boardDict.ContainsKey((r/3, c/3))) {
boardDict[(r/3, c/3)] = new HashSet<char>();
}
if(board[r][c] == '.') continue;
​
if(row[r].Contains(board[r][c]) ||
col[c].Contains(board[r][c])  ||
boardDict[(r/3, c/3)].Contains(board[r][c])) return false;
row[r].Add(board[r][c]);
col[c].Add(board[r][c]);
boardDict[(r/3, c/3)].Add(board[r][c]);
}
}
return true;`
solved last year from neetcode but retried the same approach today 10th August for Manara.
Basically the solution depending on utilizing key value pair as key, not just using a simple value as a key for the dictionary, also keeping a dictionary for rows, columns and 3 * 3 boards.