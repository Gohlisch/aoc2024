using System.Text.RegularExpressions;
using AoCUtils;

namespace Day05;

public class PartOneSolver : ISolver
{
    public string Solve(string input)
    {
        var (rules, updates) = PrintingInstructionParser.ParseRulesAndUpdates(input);

        var (valid, invalid) = PrintingInstructionParser.validAndInvalidUpdates(rules, updates);
        
        return valid.Select(list => list.CenterElement())
            .Sum()
            .ToString();
    }
}