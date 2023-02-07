namespace Ace.CSharp.Time;

/// <summary>
///     Provides System moment values
/// </summary>
public interface ISystemTime
{
    /// <summary>
    ///     Gets the current date and time on this computer,
    ///     expressed as the <b>local time</b>.
    /// </summary>
    /// <returns>A <see cref="DateTime"/> object whose value is the current local date and time.</returns>
    DateTime Now();

    /// <summary>
    ///     Gets the current date and time on this computer,
    ///     with the offset set to the <i>local time's offset</i> from <b>Coordinated Universal Time (UTC)</b>.
    /// </summary>
    /// <returns>A <see cref="DateTimeOffset"/> object whose value is the current local date and time.</returns>
    DateTimeOffset NowOffset();
}
