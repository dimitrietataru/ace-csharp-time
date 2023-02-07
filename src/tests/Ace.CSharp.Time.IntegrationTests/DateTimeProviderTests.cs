namespace Ace.CSharp.Time.Tests;

public sealed class DateTimeProviderTests
{
    private readonly IDateTimeProvider dateTimeProvider = new DateTimeProvider();
    private readonly TimeSpan precisionThreshold = TimeSpan.FromMilliseconds(1000);

    [Fact]
    internal void GivenNowThenReturnsLocalTime()
    {
        // Arrange
        var moment = DateTime.Now;

        // Act
        var actual = dateTimeProvider.Now();

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
        var actual = dateTimeProvider.NowOffset();

        // Assert
        actual.Should().BeOnOrAfter(moment);
        actual.Should().BeCloseTo(moment, precisionThreshold);
    }

    [Fact]
    internal void GivenUtcNowThenReturnsUtcTime()
    {
        // Arrange
        var moment = DateTime.UtcNow;

        // Act
        var actual = dateTimeProvider.UtcNow();

        // Assert
        actual.Should().BeOnOrAfter(moment);
        actual.Should().BeCloseTo(moment, precisionThreshold);
    }

    [Fact]
    internal void GivenUtcNowOffsetThenReturnsUtcTimeWithZeroOffset()
    {
        // Arrange
        var moment = DateTimeOffset.UtcNow;

        // Act
        var actual = dateTimeProvider.UtcNowOffset();

        // Assert
        actual.Should().BeOnOrAfter(moment);
        actual.Should().BeCloseTo(moment, precisionThreshold);
    }
}
