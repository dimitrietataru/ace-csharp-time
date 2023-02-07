namespace Ace.CSharp.Time;

/// <inheritdoc/>
public sealed class DateTimeProvider : IDateTimeProvider
{
    /// <inheritdoc/>
    public DateTime Now()
    {
        return DateTime.Now;
    }

    /// <inheritdoc/>
    public DateTimeOffset NowOffset()
    {
        return DateTimeOffset.Now;
    }

    /// <inheritdoc/>
    public DateTime UtcNow()
    {
        return DateTime.UtcNow;
    }

    /// <inheritdoc/>
    public DateTimeOffset UtcNowOffset()
    {
        return DateTimeOffset.UtcNow;
    }
}
