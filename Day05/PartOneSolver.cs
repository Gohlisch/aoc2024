using System.Text.RegularExpressions;
using AoCUtils;

namespace Day05;

public class PartOneSolver : ISolver
{
    public string Solve(string input)
    {
        var (rules, updates) = PrintingInstructionParser.ParseRulesAndUpdates(input);

        List<List<int>> validUpdates = new();
        foreach (List<int> update in updates)
        {
            update.Reverse();
            HashSet<int> shouldNotComePrior = new();
            bool valid = true;
            foreach (int page in update)
            {
                if (shouldNotComePrior.Contains(page))
                {
                    valid = false;
                    break;
                }

                if(rules.ContainsKey(page))
                {
                    shouldNotComePrior.UnionWith(rules[page]);
                }
            }

            if (valid)
            {
                validUpdates.Add(update);
            }
        }
        
        return validUpdates.Select(GetFromCenter)
            .Sum()
            .ToString();
    }

    public int GetFromCenter(List<int> list)
    {
        if (list.Count % 2 == 0)
        {
            throw new Exception();
        }

        return list[list.Count / 2];
    }
}