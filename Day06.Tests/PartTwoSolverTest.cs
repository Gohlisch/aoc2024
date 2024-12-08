using Day06;
using JetBrains.Annotations;
using Xunit;

namespace Day06.Tests;

[TestSubject(typeof(PartTwoSolver))]
public class PartTwoSolverTest
{
    private static readonly string TestInput =
        "....#.....\n.........#\n..........\n..#.......\n.......#..\n..........\n.#..^.....\n........#.\n#.........\n......#...";
    
    [Fact]
    public void Solve()
    {
        Assert.Equal("6", new PartTwoSolver().Solve(TestInput));
    }
}