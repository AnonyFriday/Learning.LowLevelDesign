using Observer.PubSub.Events;

namespace Observer.PubSub.Publishers;


// Step 2: A class that publishes/ obserable (raises) the event when ever the algorithm runs the recording finish
// ======================================================
// === Publisher/Observable
// ======================================================
public class VideoEncoder
{
    public event EventHandler<VideoEncodedEventArgs>? VideoEncoded;
    public event EventHandler<VideoEncodingStartedEventArgs>? VideoEncodingStarted;

    public void Encode(string videoTitle, int durationInSeconds)
    {
        var startTime = DateTimeOffset.Now;
        OnVideoEncodingStarted(new VideoEncodingStartedEventArgs(videoTitle, durationInSeconds, startTime));
        Console.WriteLine($"[VideoEncoder]: Encoding video '{videoTitle}' for {durationInSeconds} seconds...");

        Thread.Sleep(durationInSeconds * 1000);

        var endTime = startTime.AddSeconds(durationInSeconds);
        OnVideoEncoded(new VideoEncodedEventArgs(videoTitle, durationInSeconds, endTime));
    }

    protected virtual void OnVideoEncoded(VideoEncodedEventArgs e)
    {
        // Snapshot into a local var, THEN null-conditional invoke
        // Protects againsta a subscriber unsubscribing on another thread between the null check and the invocation
        // thread between the null-check and the call.
        var handler = VideoEncoded;
        handler?.Invoke(this, e);
    }

    protected virtual void OnVideoEncodingStarted(VideoEncodingStartedEventArgs e)
    {
        var handler = VideoEncodingStarted;
        handler?.Invoke(this, e);
    }
}
