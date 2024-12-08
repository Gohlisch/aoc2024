using Day07;
using JetBrains.Annotations;
using Xunit;

namespace Day07.Tests;

[TestSubject(typeof(MutationFactory<Operation>))]
public class MutationFactoryTest
{
    private static readonly MutationFactory<Operation> _mutationFactoryWithTwoVariations = new([Operation.Addition, Operation.Multiplication]);
    private static readonly MutationFactory<Operation> _mutationFactoryWithThreeVariations = new([Operation.Addition, Operation.Multiplication, Operation.Concatenation]);
    
    [Fact]
    public void ProducesAllMutationsForOneOperationsUsingTwoVariations()
    {
        var result = _mutationFactoryWithTwoVariations.ProduceAllMutations(1);
        
        Assert.Equal(2, result.Length);
    }
    
    [Fact]
    public void ProducesAllMutationsForTwoOperationsUsingTwoVariations()
    {
        var result = _mutationFactoryWithTwoVariations.ProduceAllMutations(2);
        
        Assert.Equal(4, result.Length);
    }
    
    [Fact]
    public void ProducesAllMutationsForThreeOperationsUsingTwoVariations()
    {
        var result = _mutationFactoryWithTwoVariations.ProduceAllMutations(3);
        
        Assert.Equal(8, result.Length);
    }
    [Fact]
    public void ProducesAllMutationsForOneOperationsUsingThreeVariations()
    {
        var result = _mutationFactoryWithThreeVariations.ProduceAllMutations(1);
        
        Assert.Equal(3, result.Length);
    }
    
    [Fact]
    public void ProducesAllMutationsForTwoOperationsUsingThreeVariations()
    {
        var result = _mutationFactoryWithThreeVariations.ProduceAllMutations(2);
        
        Assert.Equal(9, result.Length);
    }
    
    [Fact]
    public void ProducesAllMutationsForThreeOperationsUsingThreeVariations()
    {
        var result = _mutationFactoryWithThreeVariations.ProduceAllMutations(3);
        
        Assert.Equal(27, result.Length);
    }
}