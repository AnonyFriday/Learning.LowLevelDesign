using Observer.PubSub.Events;

namespace Observer.PubSub.Publishers;


// Create a subclass, as a hook, whre a subclass can plug in its own behavior
// Without having to rewrite the whole method
public class LoggingVideoEncoder : VideoEncoder
{
    protected override void OnVideoEncoded(VideoEncodedEventArgs e)
    {
        Console.WriteLine("[Logging]: <Log>This video ended, I will write down onto the log source.</Log>");
        base.OnVideoEncoded(e);
    }
}
