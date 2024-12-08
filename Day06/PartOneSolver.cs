using AoCUtils;
using Day04;

namespace Day06;

public class PartOneSolver : ISolver
{
    public string Solve(string input)
    {
        return new PatrolProtocol(new Grid(input)).ExecuteProcol().ToString();
    }

}