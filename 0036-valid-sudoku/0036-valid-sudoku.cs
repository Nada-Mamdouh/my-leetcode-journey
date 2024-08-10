public class Solution {
    public bool IsValidSudoku(char[][] board) {

        Dictionary<int, HashSet<char>> row = new Dictionary<int,HashSet<char>>();
        Dictionary<int, HashSet<char>> col = new Dictionary<int,HashSet<char>>();
        Dictionary<(int,int), HashSet<char>> boardDict = 
            new Dictionary<(int,int),HashSet<char>>();
        
        for(int r = 0;r<board.Length;r++){
            row[r] = new HashSet<char>();
            for(int c = 0;c<board[r].Length;c++){
                if(!col.ContainsKey(c)) col.Add(c, new HashSet<char>());
                if(!boardDict.ContainsKey((r/3,c/3))) boardDict.Add((r/3,c/3), new HashSet<char>());
                if(board[r][c] == '.') continue;
                if(col[c].Contains(board[r][c]) ||
                row[r].Contains(board[r][c]) ||
                boardDict[(r/3,c/3)].Contains(board[r][c])) return false;
                
                row[r].Add(board[r][c]);
                col[c].Add(board[r][c]);
                boardDict[(r/3,c/3)].Add(board[r][c]);
            }
        }
        return true;
    }
}