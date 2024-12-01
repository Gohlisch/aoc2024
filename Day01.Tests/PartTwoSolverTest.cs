using JetBrains.Annotations;
using Xunit;

namespace Day01.Tests;

[TestSubject(typeof(PartTwoSolver))]
public class PartTwoSolverTest
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
        Assert.Equal("31", new PartTwoSolver().Solve(ExampleInput));
    }
}