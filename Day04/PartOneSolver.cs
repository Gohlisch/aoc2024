using AoCUtils;

namespace Day04;

public class PartOneSolver : ISolver
{
    public string Solve(string input)
    {
        return new WordSearcher(new Grid(input), "XMAS").Count().ToString();
    }

}