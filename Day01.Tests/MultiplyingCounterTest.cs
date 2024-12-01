using System.Collections.Generic;
using JetBrains.Annotations;
using Xunit;

namespace Day01.Tests;

[TestSubject(typeof(MultiplyingCounter))]
public class MultiplyingCounterTest
{
    [Fact]
    public void CountsElementsAndMultipliesByTheElementValue()
    {
        List<int> input = [4, 3, 5, 3, 9, 3];
        var distanceMultiplier = new MultiplyingCounter();

        var result = distanceMultiplier.CountAndMultiply(input);

        Assert.Equal(9, result.GetValueOrDefault(3));
        Assert.Equal(4, result.GetValueOrDefault(4));
        Assert.Equal(0, result.GetValueOrDefault(2));
        Assert.Equal(0, result.GetValueOrDefault(1));
    }
}