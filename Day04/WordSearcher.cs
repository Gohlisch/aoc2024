namespace Day04;

public class WordSearcher(Grid grid, string word)
{
    public int Count()
    {
        int count = 0;

        char lookOutFor = word[0];
        for (int col = 0; col < grid.Cols; col++)
        {
            for (int row = 0; row < grid.Rows; row++)
            {
                if (grid.Get(row, col) == lookOutFor)
                {
                    // south
                    if (SearchForWorkInDirection(row, col, 1, 0))
                    {
                        count++;
                    }
                    // south-east
                    if (SearchForWorkInDirection(row, col, 1, 1))
                    {
                        count++;
                    }
                    // east
                    if (SearchForWorkInDirection(row, col, 0, 1))
                    {
                        count++;
                    }
                    // north-east
                    if (SearchForWorkInDirection(row, col, -1, 1))
                    {
                        count++;
                    }
                    // north
                    if (SearchForWorkInDirection(row, col, -1, 0))
                    {
                        count++;
                    }
                    // north-west
                    if (SearchForWorkInDirection(row, col, -1, -1))
                    {
                        count++;
                    }
                    // west
                    if (SearchForWorkInDirection(row, col, 0, -1))
                    {
                        count++;
                    }
                    // south-west
                    if (SearchForWorkInDirection(row, col, 1, -1))
                    {
                        count++;
                    }
                }
            }
        }

        return count;
    }

    private bool SearchForWorkInDirection(int startRow, int startCol, int stepVertical, int stepHorizontal)
    {
        int row = startRow;
        int col = startCol;
        foreach (char character in word)
        {
            if (grid.OutOfBounds(row, col) || grid.Get(row, col) != character) return false;
            col += stepHorizontal;
            row += stepVertical;
        }

        return true;
    }
}