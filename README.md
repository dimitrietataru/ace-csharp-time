# C# time

### What is AceCSharp.Time
It's a library, that exposes DI-ready and mockable implementation of current date and time, or date and time with offset.

### Usage
``` csharp
IDateTimeProvider dateTimeProvider = new DateTimeProvider();

DateTime moment = dateTimeProvider.Now();
DateTime momentInUtc = dateTimeProvider.UtcNow();

DateTimeOffset momentWithOffset = dateTimeProvider.NowOffset();
DateTimeOffset momentWithZeroOffset = dateTimeProvider.UtcNowOffset();
```

``` csharp
ISystemTime systemTime = new SystemTime();

DateTime moment = systemTime.Now();
DateTime momentInUtc = systemTime.UtcNow();
```

### License
AceCSharp.Time is Copyright © 2022 [Dimitrie Tataru](https://github.com/dimitrietataru) and other contributors under the [MIT license](https://github.com/dimitrietataru/ace-csharp-time/blob/ace/LICENSE).
