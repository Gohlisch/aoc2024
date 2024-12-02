using JetBrains.Annotations;

namespace Day02.Tests;

[TestSubject(typeof(ReportSafetyValidator))]
public class ReportSafetyValidatorTest
{
    private readonly ReportSafetyValidator _validator = new();

    [Fact]
    public void Validate_IsValid_IfWhenAllAreDecreasingGradually()
    {
        var report = new Report([7, 6, 4, 2, 1]);
        Assert.True(_validator.Validate(report));
    }

    [Fact]
    public void Validate_IsValid_IfWhenAllAreIncreasingGradually()
    {
        var report = new Report([1, 3, 6, 7, 9]);
        Assert.True(_validator.Validate(report));
    }

    [Fact]
    public void Validate_IsInvalid_IfIncreaseToBig()
    {
        var report = new Report([1, 2, 7, 8, 9]);
        Assert.False(_validator.Validate(report));
    }
    
    [Fact]
    public void Validate_IsInvalid_IfDecreaseToBig()
    {
        var report = new Report([9, 7, 6, 2, 1]);
        Assert.False(_validator.Validate(report));
    }

    [Fact]
    public void Validate_IsInvalid_IfOnlyPartsAreDecreasingOrIncreasingGradually()
    {
        var report = new Report([1, 3, 2, 4, 5]);
        Assert.False(_validator.Validate(report));
    }

    [Fact]
    public void Validate_IsInvalid_IfNoGraduallyChangeIsToBeFound()
    {
        var report = new Report([8, 6, 4, 4, 1]);
        Assert.False(_validator.Validate(report));
    }

    [Fact]
    public void Validate_IsValid_IfWhenAllAreDecreasingGraduallyWithToleranceOfOneBadChange()
    {
        var report = new Report([7, 6, 4, 2, 1]);
        _validator.ProblemDampenerActive = true;
        Assert.True(_validator.Validate(report));
    }

    [Fact]
    public void Validate_IsInvalid_IfIncreaseToBigWithToleranceOfOneBadChange()
    {
        var report = new Report([1, 2, 7, 8, 9]);
        _validator.ProblemDampenerActive = true;
        Assert.False(_validator.Validate(report));
    }

    [Fact]
    public void Validate_IsInvalid_IfDecreaseToBigWithToleranceOfOneBadChange()
    {
        var report = new Report([9, 7, 6, 2, 1]);
        _validator.ProblemDampenerActive = true;
        Assert.False(_validator.Validate(report));
    }

    [Fact]
    public void Validate_Valid_IfAllButOneValueAreIncreasingGraduallyAndToleratedBadLevelAmountIsSetToOne()
    {
        var report = new Report([1, 3, 2, 4, 5]);
        _validator.ProblemDampenerActive = true;
        Assert.True(_validator.Validate(report));
    }

    [Fact]
    public void Validate_Valid_IfAllButOneValueAreDecreasingGraduallyAndToleratedBadLevelAmountIsSetToOne()
    {
        var report = new Report([8, 6, 4, 4, 1]);
        _validator.ProblemDampenerActive = true;
        Assert.True(_validator.Validate(report));
    }

    [Fact]
    public void Validate_IsValid_IfWhenAllAreIncreasingGraduallyWithToleranceOfOneBadChange()
    {
        var report = new Report([1, 3, 6, 7, 9]);
        _validator.ProblemDampenerActive = true;
        Assert.True(_validator.Validate(report));
    }
}