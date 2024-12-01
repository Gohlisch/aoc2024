using System.Collections.Generic;
using JetBrains.Annotations;
using Xunit;

namespace Day01.Tests;

[TestSubject(typeof(DistanceReader))]
public class DistanceReaderTest
{
    private const string ExampleInput = "3   4\n"
                                        + "4   3\n"
                                        + "2   5\n"
                                        + "1   3\n"
                                        + "3   9\n"
                                        + "3   3\n";

    [Fact]
    public void ParsesNumbersAndSorts()
    {
        List<int> expectedSortedLeft = [1, 2, 3, 3, 3, 4];
        List<int> expectedSortedRight = [3, 3, 3, 4, 5, 9];
        
        var distanceReader = new DistanceReader();
        var (left, right) = distanceReader.Read(ExampleInput);

        for (int i = 0; i < left.Count; i++)
        {
            Assert.Equal(expectedSortedLeft[i], left[i]);
            Assert.Equal(expectedSortedRight[i], right[i]);
        }
    }
}