namespace Observer.Observable.Events;

// just like the EventArgs in the traditional event-based observer pattern
// but we simulate the object that would be passed into the stream
public class VideoEncodedEventArgs
{
    public string Title { get; }
    public int DurationInSeconds { get; }
    public DateTimeOffset EndTime { get; }

    public VideoEncodedEventArgs(string title, int durationInSeconds, DateTimeOffset endTime)
    {
        Title = title;
        DurationInSeconds = durationInSeconds;
        EndTime = endTime;
    }
}
