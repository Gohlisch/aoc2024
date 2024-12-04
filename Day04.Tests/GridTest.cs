using Day04;
using JetBrains.Annotations;
using Xunit;

namespace Day04.Tests;

[TestSubject(typeof(Grid))]
public class GridTest
{
    private readonly Grid _grid = new ("ABCD\n"
                                       + "EFGH\n"
                                       + "IJKL\n"
                                       + "MNOP\n"
                                       + "QRST\n"
                                       + "UVWX");

    [Fact]
    public void GetsCharFromFirstRowFirstColumn()
    {
        Assert.Equal('A', _grid.Get(0, 0));
    }

    [Fact]
    public void GetCharFromFirstRowSecondColumn()
    {
        Assert.Equal('B', _grid.Get(0, 1));
    }

    [Fact]
    public void GetsCharFromFirstRowLastColumn()
    {
        Assert.Equal('D', _grid.Get(0, 3));
    }
    
    [Fact]
    public void GetsCharFromSecondRowFirstColumn()
    {
        Assert.Equal('E', _grid.Get(1, 0));
    }

    [Fact]
    public void GetCharFromSecondRowSecondColumn()
    {
        Assert.Equal('F', _grid.Get(1, 1));
    }

    [Fact]
    public void GetsCharFromSecondRowLastColumn()
    {
        Assert.Equal('H', _grid.Get(1, 3));
    }

    [Fact]
    public void GetsCharFromLastRowFirstColumn()
    {
        Assert.Equal('U', _grid.Get(5, 0));
    }

    [Fact]
    public void GetsCharFromLastRowSecondColumn()
    {
        Assert.Equal('V', _grid.Get(5, 1));
    }

    [Fact]
    public void GetsCharFromLastRowLastColumn()
    {
        Assert.Equal('X', _grid.Get(5, 3));
    }
    
    [Fact]
    public void GetsCharFromLastRowLastColumnByUsingNegativeCoordinates()
    {
        Assert.Equal('X', _grid.Get(-1, -1));
    }
    
    [Fact]
    public void GetsCharFromLastRowFirstColumnByUsingNegativeCoordinates()
    {
        Assert.Equal('U', _grid.Get(-1, 0));
    }

    [Fact]
    public void GetsCharFromLastRowSecondColumnByUsingNegativeCoordinates()
    {
        Assert.Equal('V', _grid.Get(-1, -3));
    }

    [Fact]
    public void GetsCharFromACentralPositionUsingNegativeCoordinates()
    {
        Assert.Equal('N', _grid.Get(-3, -3));
    }
}