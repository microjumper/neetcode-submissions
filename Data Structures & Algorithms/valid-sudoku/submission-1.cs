public class Solution
{
    private readonly char emptyTile = '.';
    
    public bool IsValidSudoku(char[][] board)
    {
        var row = new HashSet<char>();
        var columns = new Dictionary<int, HashSet<char>>();
        var boxes = new Dictionary<(int, int), HashSet<char>>();

        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[0].Length; j++)
            {
                if (i == 0)
                {
                    columns[j] = new();
                }

                if (board[i][j] != emptyTile)
                {
                    if (!row.Add(board[i][j]))
                    {
                        return false;
                    }

                    if (!columns[j].Add(board[i][j]))
                    {
                        return false;
                    }

                    var boxKey = (i / 3, j / 3);
                    if (!boxes.ContainsKey(boxKey))
                    {
                        boxes[boxKey] = new HashSet<char>();
                    }

                    if (!boxes[boxKey].Add(board[i][j]))
                    {
                        return false;
                    }
                }
            }

            row.Clear();
        }

        return true;
    }
}
