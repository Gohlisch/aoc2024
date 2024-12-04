using Day04;
using JetBrains.Annotations;
using Xunit;

namespace Day04.Tests;

[TestSubject(typeof(Grid))]
public class GridTest
{
    private Grid grid = new ("ABCD\n"
                             + "EFGH\n"
                             + "IJKL\n"
                             + "MNOP\n"
                             + "QRST\n"
                             + "UVWX");

    [Fact]
    public void getsCharFromFirstRowFirstColumn()
    {
        Assert.Equal('A', grid.get(0, 0));
    }

    [Fact]
    public void getCharFromFirstRowSecondColumn()
    {
        Assert.Equal('B', grid.get(0, 1));
    }

    [Fact]
    public void getsCharFromFirstRowLastColumn()
    {
        Assert.Equal('D', grid.get(0, 3));
    }
    
    [Fact]
    public void getsCharFromSecondRowFirstColumn()
    {
        Assert.Equal('E', grid.get(1, 0));
    }

    [Fact]
    public void getCharFromSecondRowSecondColumn()
    {
        Assert.Equal('F', grid.get(1, 1));
    }

    [Fact]
    public void getsCharFromSecondRowLastColumn()
    {
        Assert.Equal('H', grid.get(1, 3));
    }

    [Fact]
    public void getsCharFromLastRowFirstColumn()
    {
        Assert.Equal('U', grid.get(5, 0));
    }

    [Fact]
    public void getsCharFromLastRowSecondColumn()
    {
        Assert.Equal('V', grid.get(5, 1));
    }

    [Fact]
    public void getsCharFromLastRowLastColumn()
    {
        Assert.Equal('X', grid.get(5, 3));
    }
}