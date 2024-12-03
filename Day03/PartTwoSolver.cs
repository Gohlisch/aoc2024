using System.Text.RegularExpressions;
using System.Xml.Schema;
using AoCUtils;

namespace Day03;

public class PartTwoSolver : ISolver
{
    public string Solve(string input)
    {
        string cleanedInput = 
            Regex.Replace(input.ReplaceLineEndings(""), 
                    @"((don't\(\)).*?(do\(\)))", 
                    "")
                .Split("don't")
                .First();
        
        
            string pattern = @"mul\((\d+),(\d+)\)";
        return Regex.Matches(cleanedInput, pattern, RegexOptions.Multiline | RegexOptions.Compiled)
            .Where(match => match.Groups.Count > 2)
            .Select(a => PartTwoSolver.ParseMulInstruction(a))
            .Select(tuple => tuple.Item1 * tuple.Item2)
            .Aggregate((a, b) => a + b)
            .ToString();
    }
    
    

    private static (int, int) ParseMulInstruction(Match input)
    {
        return (int.Parse(input.Groups[1].Value), int.Parse(input.Groups[2].Value));
    }
}