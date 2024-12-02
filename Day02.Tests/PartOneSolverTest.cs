using Day02;
using JetBrains.Annotations;

namespace Day02.Tests;

[TestSubject(typeof(PartOneSolver))]
public class PartOneSolverTest
{
    private const string ExampleInput = "7 6 4 2 1\n1 2 7 8 9\n9 7 6 2 1\n1 3 2 4 5\n8 6 4 4 1\n1 3 6 7 9\n";
    
    [Fact]
    public void IsTrue()
    {
        PartOneSolver solver = new PartOneSolver();
        Assert.Equal("2", solver.Solve(ExampleInput));
    }
}