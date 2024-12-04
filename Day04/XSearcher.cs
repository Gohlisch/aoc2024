namespace Day04;

public class XSearcher(Grid grid)
{
    public int Count()
    {
        int count = 0;

        for (int col = 0; col < grid.Cols; col++)
        {
            for (int row = 0; row < grid.Rows; row++)
            {
                if (grid.Get(row, col) == 'A' && SearchForMAndS(row, col))
                {
                    ++count;
                }
            }
        }

        return count;
    }

    private bool SearchForMAndS(int row, int col)
    {
        return (
                !grid.OutOfBounds(row - 1, col - 1)
                && grid.Get(row - 1, col - 1) == 'S'
                && !grid.OutOfBounds(row + 1, col + 1)
                && grid.Get(row + 1, col + 1) == 'M'
                || 
                !grid.OutOfBounds(row - 1, col - 1)
                && grid.Get(row - 1, col - 1) == 'M'
                && !grid.OutOfBounds(row + 1, col + 1)
                && grid.Get(row + 1, col + 1) == 'S'
                )
               &&
               (
                   !grid.OutOfBounds(row - 1, col + 1)
                   && grid.Get(row - 1, col + 1) == 'S'
                   && !grid.OutOfBounds(row + 1, col - 1)
                   && grid.Get(row + 1, col - 1) == 'M'
                   || 
                   !grid.OutOfBounds(row - 1, col + 1)
                   && grid.Get(row - 1, col + 1) == 'M'
                   && !grid.OutOfBounds(row + 1, col - 1)
                   && grid.Get(row + 1, col - 1) == 'S'
               );
    }
}