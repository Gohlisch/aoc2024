namespace Day04;

public class Grid
{
    private int rows;
    private int cols;
    private readonly char[] _grid;

    public Grid(string from)
    {
        var splits = from.Split("\n");
        rows = splits.Length;
        cols = splits[0].Length;
        _grid = from.Replace("\n", "").ToCharArray();
    }

    public char get(int row, int col)
    {
      return _grid[row*cols+col];  
    }
}