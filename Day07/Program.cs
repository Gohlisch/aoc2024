namespace Day07;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Day 7 - Puzzle 1");
        Console.WriteLine(new PartOneSolver().Solve(Puzzle.input));
        Console.WriteLine("Day 7 - Puzzle 2");
        Console.WriteLine(new PartTwoSolver().Solve(Puzzle.input));
    }
}