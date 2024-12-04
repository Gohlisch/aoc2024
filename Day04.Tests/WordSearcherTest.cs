using Day04;
using JetBrains.Annotations;
using Xunit;

namespace Day04.Tests;

[TestSubject(typeof(WordSearcher))]
public class WordSearcherTest
{
    private static readonly Grid Grid = new("MMMSXXMASM\nMSAMXMSMSA\nAMXSXMAAMM\nMSAMASMSMX\nXMASAMXAMM\nXXAMMXXAMA\nSMSMSASXSS\nSAXAMASAAA\nMAMMMXMMMM\nMXMXAXMASX");
    private readonly WordSearcher _wordSearcher = new(Grid, "XMAS");

    [Fact]
    public void FindsAllOccurrences()
    {
        Assert.Equal(18, _wordSearcher.Count());
    }
}