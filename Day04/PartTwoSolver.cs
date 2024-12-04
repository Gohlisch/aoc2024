using System.Text.RegularExpressions;
using System.Xml.Schema;
using AoCUtils;

namespace Day04;

public class PartTwoSolver : ISolver
{
    public string Solve(string input)
    {
        return new XSearcher(new Grid(input)).Count().ToString();
    }
}