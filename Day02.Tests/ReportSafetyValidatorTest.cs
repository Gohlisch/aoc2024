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
}