using Day03;
using JetBrains.Annotations;

namespace Day03;

[TestSubject(typeof(PartTwoSolver))]
public class PartTwoSolverTest
{
    private string exampleInput = "xmul(2,4)&mul[3,7]!^don't()_mul(5,5)+mul(32,64](mul(11,8)undo()?mul(8,5))";
    
    [Fact]
    public void solve()
    {
        var solver = new PartTwoSolver();
        var result = solver.Solve(exampleInput);
        Assert.Equal("48", result);
    }
}