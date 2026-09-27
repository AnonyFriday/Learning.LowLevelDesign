using Observer.Observable.Events;

namespace Observer.Observable.Observers;

public class NotificationService(string serviceName) : IObserver<VideoEncodedEventArgs>
{
    private readonly string _serviceName = serviceName;
    private IDisposable? _unsubscriber;

    public void Unsubscribe()
    {
        _unsubscriber?.Dispose();
    }

    public void Subscribe(IObservable<VideoEncodedEventArgs> provider)
    {
        if (provider != null)
            _unsubscriber = provider.Subscribe(this);
    }

    public void OnCompleted()
    {
        return;
    }

    public void OnError(Exception error)
    {
        Console.WriteLine($"[NotificationService]: Error occurred - {error.Message}");
    }

    public void OnNext(VideoEncodedEventArgs value)
    {
        SendEmail("admin@example.com", "All videos encoded", "All videos have been encoded successfully.");
    }

    private void SendEmail(string emailAddress, string subject, string body)
    {
        Console.WriteLine($"[{_serviceName}]: Sending to {emailAddress} — subject: '{subject}'");
    }
}
