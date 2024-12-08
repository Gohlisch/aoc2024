using Day07;
using JetBrains.Annotations;
using Xunit;

namespace Day07.Tests;

[TestSubject(typeof(MutationFactory))]
public class MutationFactoryTest
{
    private static readonly MutationFactory _mutationFactory = new();
    
    [Fact]
    public void ProducesAllMutationsForOneOperations()
    {
        var result = _mutationFactory.ProduceAllMutations(1);
        
        Assert.Equal(2, result.Length);
    }
    
    [Fact]
    public void ProducesAllMutationsForTwoOperations()
    {
        var result = _mutationFactory.ProduceAllMutations(2);
        
        Assert.Equal(4, result.Length);
    }
    
    [Fact]
    public void ProducesAllMutationsForThreeOperations()
    {
        var result = _mutationFactory.ProduceAllMutations(3);
        
        Assert.Equal(8, result.Length);
    }
}