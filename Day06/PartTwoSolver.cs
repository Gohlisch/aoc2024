using AoCUtils;
using Day04;

namespace Day06;

public class PartTwoSolver : ISolver
{
    public string Solve(string input)
    {
        return new LoopDetector(new Grid(input)).CountWaysToCreateALoop().ToString();
    }
}