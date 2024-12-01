using JetBrains.Annotations;
using Xunit;

namespace Day01.Tests;

[TestSubject(typeof(PartOneSolver))]
public class PartOneSolverTest
{
    private const string ExampleInput = "3   4\n"
                                        + "4   3\n"
                                        + "2   5\n"
                                        + "1   3\n"
                                        + "3   9\n"
                                        + "3   3\n";

    [Fact]
    public void PassingTest()
    {
        var solver = new PartOneSolver();
        Assert.Equal("11", solver.Solve(ExampleInput));
    }
}