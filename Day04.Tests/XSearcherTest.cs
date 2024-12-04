using Day04;
using JetBrains.Annotations;
using Xunit;

namespace Day04.Tests;

[TestSubject(typeof(XSearcher))]
public class XSearcherTest
{
    private readonly XSearcher _xSearcher =
        new(new Grid(
            "MMMSXXMASM\nMSAMXMSMSA\nAMXSXMAAMM\nMSAMASMSMX\nXMASAMXAMM\nXXAMMXXAMA\nSMSMSASXSS\nSAXAMASAAA\nMAMMMXMMMM\nMXMXAXMASX"));
    
    [Fact]
    public void CountAllMasCrosses()
    {
        Assert.Equal(9, _xSearcher.Count());
    }
}