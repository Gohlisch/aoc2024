namespace Day04;

public class Grid
{
    private int _rows;
    private int _cols;
    private readonly char[] _grid;

    public Grid(string from)
    {
        var splits = from.Split("\n");
        _rows = splits.Length;
        _cols = splits[0].Length;
        _grid = from.Replace("\n", "").ToCharArray();
    }

    public char Get(int row, int col)
    {
        while (row < 0)
        {
            row += _rows;
        }
        while (col < 0)
        {
            col += _cols;
        }
        return _grid[row * _cols + col];
    }
}