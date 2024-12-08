using Day04;

namespace Day06;

public class LoopDetector(Grid labMap)
{
    private readonly Grid labMap = labMap;

    public int CountWaysToCreateALoop()
    {
        int loopsFound = 0;
        
        for (int row = 0; row < labMap.Rows; row++)
        {
            for (int col = 0; col < labMap.Cols; col++)
            {
                if (labMap.Get(row, col) == '.')
                {
                    Grid clone = labMap.Clone();
                    clone.Set(row, col, 'O');
                    try
                    {
                        new PatrolProtocol(clone).ExecuteProtocol();
                    }
                    catch(LoopDetectionException _)
                    {
                        loopsFound += 1;
                    }
                }
            }
        }

        return loopsFound;
    }
}