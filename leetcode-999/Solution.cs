namespace leetcode_999
{
    public class Solution
    {
        public int NumRookCaptures(char[][] board)
        {
            var R = new int[2];
            for (var y = 0; y < board.Length; y++)
            for (var x = 0; x < board.Length; x++)
                if (board[x][y] == 'R')
                    R = new[] {x, y};

            var n = 0;


            for (var i = R[0] - 1; i >= 0; i--)
                if (board[i][R[1]] == 'B') break;
                else if (board[i][R[1]] == 'p')
                {
                    n++;
                    break;
                }
            
            for (var i = R[0]+1; i < board.Length; i++)
                if (board[i][R[1]] == 'B') break;
                else if (board[i][R[1]] == 'p')
                {
                    n++;
                    break;
                }
            
            for (var i = R[1] - 1; i >= 0; i--)
                if (board[R[0]][i] == 'B') break;
                else if (board[R[0]][i] == 'p')
                {
                    n++;
                    break;
                }
            
            for (var i = R[0]+1; i < board.Length; i++)
                if (board[R[0]][i] == 'B') break;
                else if (board[R[0]][i] == 'p')
                {
                    n++;
                    break;
                }

            return n;
        }
    }
}