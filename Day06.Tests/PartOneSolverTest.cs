using Day06;
using JetBrains.Annotations;
using Xunit;

namespace Day06.Tests;

[TestSubject(typeof(PartOneSolver))]
public class PartOneSolverTest
{
    private static readonly string TestInput =
        "....#.....\n.........#\n..........\n..#.......\n.......#..\n..........\n.#..^.....\n........#.\n#.........\n......#...";

    private PartOneSolver solver = new();
    
    [Fact]
    public void Solves()
    {
        Assert.Equal("41", solver.Solve(TestInput));
    }
}