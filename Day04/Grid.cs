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

    public bool OutOfBounds(int row, int col)
    {
        return row < 0 || row >= Rows || col < 0 || col >= Cols;
    }
}