namespace Observer.PubSub.Events;

public class VideoEncodingStartedEventArgs : EventArgs
{
    public string Title { get; } = string.Empty;
    public int DurationInSeconds { get; }
    public DateTimeOffset StartTime { get; }

    public VideoEncodingStartedEventArgs(string title, int durationInSeconds, DateTimeOffset startTime)
    {
        Title = title;
        DurationInSeconds = durationInSeconds;
        StartTime = startTime;
    }
}
