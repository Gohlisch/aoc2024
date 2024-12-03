using Day03;

namespace Day03;

public class PartOneSolverTest
{
    private string exampleInput = "xmul(2,4)%&mul[3,7]!@^do_not_mul(5,5)+mul(32,64]then(mul(11,8)mul(8,5))";
    
    
    [Fact]
    public void Test1()
    {
        var solver = new PartOneSolver();
        var result = solver.Solve(exampleInput);
        Assert.Equal("161", result);
    }
}