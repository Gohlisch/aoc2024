using System.Text.RegularExpressions;
using AoCUtils;

namespace Day05;

public class PartTwoSolver : ISolver
{
    public string Solve(string input)
    {
        var (rules, updates) = PrintingInstructionParser.ParseRulesAndUpdates(input);

        var (_, invalid) = PrintingInstructionParser.validAndInvalidUpdates(rules, updates);

        int res = 0;
        foreach (List<int> toBeOrdered in invalid)
        {
            List<int> ordered = new();
            foreach (var page in toBeOrdered)
            {
                int lowestInsertKey = 0;
                for (int i = 0; i < ordered.Count; i++)
                {
                    if (rules.ContainsKey(ordered[i]) && rules[ordered[i]].Contains(page))
                    {
                        lowestInsertKey = i+1;
                    }
                }

                ordered.Insert(lowestInsertKey, page);
            }

            res += ordered.CenterElement();
        }
        
        return res.ToString();
    }
}