using Observer.PubSub.Publishers;
using Observer.PubSub.Subcribers;

namespace Observer.PubSub;

internal partial class Program
{
    public static void Main(string[] args)
    {
        var notificationService = new NotificationService();
        var loggingVideoEncoder = new LoggingVideoEncoder();

        // as long as matching the same signature, the method can be subscribed to the event
        loggingVideoEncoder.VideoEncodingStarted += notificationService.OnVideoEncodingStarted;
        loggingVideoEncoder.VideoEncoded += notificationService.OnVideoEncoded;

        loggingVideoEncoder.Encode("FUNNY", 6);

        Console.ReadLine();
    }
}