namespace Day05;

public class PrintingInstructionParser
{
    public static (Dictionary<int, HashSet<int>> rules, List<List<int>> updates) ParseRulesAndUpdates(string input)
    {
        Dictionary<int, HashSet<int>> rules = new();

        var lines = input.Split(Environment.NewLine);
        int index = 0;
        for (; index < lines.Length; index++)
        {
            var line = lines[index];
            if (line.Length == 0) break;
            var rule = line.Split("|").Select(int.Parse).ToList();
            if (!rules.ContainsKey(rule[0]))
            {
                rules[rule[0]] = new HashSet<int>();
            }

            rules[rule[0]].Add(rule[1]);
        }

        index++;
        List<List<int>> updates = new();
        for (; index < lines.Length; index++)
        {
            var line = lines[index];
            if (line.Length == 0) break;
            updates.Add(line.Split(",").Select(int.Parse).ToList());
        }

        return (rules, updates);
    }
}