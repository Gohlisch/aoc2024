using Day08;
using JetBrains.Annotations;
using Xunit;

namespace Day08.Tests;

[TestSubject(typeof(PartTwoSolver))]
public class PartTwoSolverTest
{
    private static readonly PartTwoSolver Solver = new();

    private static readonly string TestInput =
        "............\n........0...\n.....0......\n.......0....\n....0.......\n......A.....\n............\n............\n........A...\n.........A..\n............\n............";
    
    [Fact]
    public void Solves()
    {
        Assert.Equal("34", Solver.Solve(TestInput));
    }
}