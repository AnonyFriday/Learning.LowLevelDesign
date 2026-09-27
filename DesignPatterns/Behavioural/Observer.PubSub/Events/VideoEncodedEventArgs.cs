namespace Observer.PubSub.Events;


// Step 1: Define a class that captures the event data
// ======================================================
// === Event Data
// ======================================================

public class VideoEncodedEventArgs : EventArgs
{
    public string Title { get; } = string.Empty;
    public int DurationInSeconds { get; }
    public DateTimeOffset EndTime { get; }

    public VideoEncodedEventArgs(string title, int duration, DateTimeOffset endTime)
    {
        Title = title;
        DurationInSeconds = duration;
        EndTime = endTime;
    }
}
