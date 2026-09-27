using Observer.PubSub.Events;

namespace Observer.PubSub.Subcribers;

// Step 3: A class that subscribes to the event and handles it
public class NotificationService
{
    public void PrepareEmail(string emailAddress, string subject, string body)
    {
        Console.WriteLine("[NotificationService]: Preparing email to {0} with subject '{1}' and body '{2}'", emailAddress, subject, body);
    }

    public void SendEmail(string emailAddress, string subject, string body)
    {
        Console.WriteLine("[Email]: Sending email to {0} with subject '{1}' and body '{2}'", emailAddress, subject, body);
        Thread.Sleep(5000);
        Console.WriteLine("[Email]: Email sent to {0}", emailAddress);
    }

    // subscriber do something after receiving the event

    public void OnVideoEncodingStarted(object? source, VideoEncodingStartedEventArgs e)
    {
        Console.WriteLine(nameof(PrepareEmail));
    }

    public void OnVideoEncoded(object? source, VideoEncodedEventArgs e)
    {
        Console.WriteLine(nameof(SendEmail));
        SendEmail("duyvukim@gmail.com", $"Video Encoding Started: {e.Title}", $"The video ended at: {e.EndTime}");
    }
}
