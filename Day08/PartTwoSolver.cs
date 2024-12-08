using AoCUtils;
using Day04;

namespace Day08;

public class PartTwoSolver : ISolver
{
    public string Solve(string input)
    {
        return new AntiNodeFinder(new Grid(input)).CountUniqueAntinodes(true).ToString();
    }
}