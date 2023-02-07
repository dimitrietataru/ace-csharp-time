namespace Ace.CSharp.Time.Tests;

public sealed class SystemTimeTests
{
    private readonly ISystemTime systemTime = new SystemTime();
    private readonly TimeSpan precisionThreshold = TimeSpan.FromMilliseconds(1000);

    [Fact]
    internal void GivenNowThenReturnsLocalTime()
    {
        // Arrange
        var moment = DateTime.Now;

        // Act
        var actual = systemTime.Now();

        // Assert
        actual.Should().BeOnOrAfter(moment);
        actual.Should().BeCloseTo(moment, precisionThreshold);
    }

    [Fact]
    internal void GivenNowOffsetThenReturnsLocalTimeWithOffset()
    {
        // Arrange
        var moment = DateTimeOffset.Now;

        // Act
        var actual = systemTime.NowOffset();

        // Assert
        actual.Should().BeOnOrAfter(moment);
        actual.Should().BeCloseTo(moment, precisionThreshold);
    }
}
