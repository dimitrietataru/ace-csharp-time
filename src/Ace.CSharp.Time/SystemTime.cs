namespace Ace.CSharp.Time;

/// <inheritdoc/>
public sealed class SystemTime : ISystemTime
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
}
