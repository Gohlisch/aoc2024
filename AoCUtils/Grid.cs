namespace Day04;

public class Grid
{
    public readonly int Rows;
    public readonly int Cols;
    private readonly char[] _grid;

    public Grid(string from)
    {
        var splits = from.Split(Environment.NewLine).Where(n => n.Length > 0).ToArray();
        Rows = splits.Length;
        Cols = splits[0].Length;
        _grid = from.ReplaceLineEndings("").ToCharArray();
    }

    public Grid(int rows, int cols, char fill)
    {
        Rows = rows;
        Cols = cols;
        _grid = new char[rows * cols];
        Array.Fill(_grid, fill);
    }
    
     

    public char Get(int row, int col)
    {
        row %= Rows;
        col %= Cols;
        
        if (row < 0)
        {
            row += Rows;
        }
        if (col < 0)
        {
            col += Cols;
        }
        
        return _grid[row * Cols + col];
    }

    public void Set(int row, int col, char newValue)
    {
        row %= Rows;
        col %= Cols;
        
        if (row < 0)
        {
            row += Rows;
        }
        if (col < 0)
        {
            col += Cols;
        }
        
        _grid[row * Cols + col] = newValue;
    }

    public List<(int, int)> FindAllLocations(char of)
    {
        List<(int, int)> locations = new List<(int, int)>();

        for (int row = 0; row < Rows; row++)
        {
            for (int col = 0; col < Cols; col++)
            {
                if (_grid[row * Cols + col] == of)
                {
                    locations.Add((row, col));
                }
            }
        }

        return locations;
    }

    public bool OutOfBounds(int row, int col)
    {
        return row < 0 || row >= Rows || col < 0 || col >= Cols;
    }

    public Grid Clone()
    {
        var copy = new Grid(Rows, Cols, ' ');
        
        for (int row = 0; row < Rows; row++)
        {
            for (int col = 0; col < Cols; col++)
            {
                copy.Set(row, col, this.Get(row, col));
            }
        }

        return copy;
    }
}