using Day07;
using JetBrains.Annotations;
using Xunit;

namespace Day07.Tests;

[TestSubject(typeof(PartOneSolver))]
public class PartOneSolverTest
{
    private static readonly string ExampleInput =
        "190: 10 19\n3267: 81 40 27\n83: 17 5\n156: 15 6\n7290: 6 8 6 15\n161011: 16 10 13\n192: 17 8 14\n21037: 9 7 18 13\n292: 11 6 16 20";
    
    [Fact]
    public void Passes()
    {
        Assert.Equal("3749", new PartOneSolver().Solve(ExampleInput));
    }
}