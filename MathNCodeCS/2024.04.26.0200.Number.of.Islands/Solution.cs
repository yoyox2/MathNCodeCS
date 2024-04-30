namespace MathNCodeCS._2024._04._26._0200.Number.of.Islands;

// 200 Number of Islands
// https://leetcode.com/problems/number-of-islands/

public class Solution
{
    public int NumIslands(char[][] grid)
    {

        int rowSize = grid.Length;
        int colSize = grid[0].Length;

        var visited = new HashSet<(int, int)>();

        int numIslands = 0;

        for( int i = 0; i < rowSize; i++)
        {
            for(int j = 0; j < colSize; j++) {
                numIslands += Dfs(i, j);
            }
        }

        return numIslands;

        int Dfs(int r, int c)
        {
            //out of scope
            if(r<0 || r>= rowSize || c < 0 || c >= colSize)
            {
                return 0;
            }

            //visited
            if (visited.Contains((r, c))){
                return 0;
            }

            //not land
            if (grid[r][c] == '0')
            {
                return 0;
            }

            visited.Add((r, c));

            Dfs(r + 1, c);
            Dfs(r-1, c);
            Dfs(r, c + 1);
            Dfs(r, c - 1);

            return 1;
        }
    }
}
