using Day08;
using JetBrains.Annotations;
using Xunit;

namespace Day08.Tests;

[TestSubject(typeof(PartOneSolver))]
public class PartOneSolverTest
{
    private static readonly PartOneSolver Solver = new();

    private const string TestInput = "............\n........0...\n.....0......\n.......0....\n....0.......\n......A.....\n............\n............\n........A...\n.........A..\n............\n............";

    [Fact]
    public void Solves()
    {
        Assert.Equal("14", Solver.Solve(TestInput));
    }
}