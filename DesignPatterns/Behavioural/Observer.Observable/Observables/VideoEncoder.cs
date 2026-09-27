using Observer.Observable.Events;

namespace Observer.Observable.Observables;

public class VideoEncoder : IObservable<VideoEncodedEventArgs>
{
    private readonly List<IObserver<VideoEncodedEventArgs>> _observers = new();

    // Just like we define the EventHandler, a middleman to register the Observer
    public IDisposable Subscribe(IObserver<VideoEncodedEventArgs> observer)
    {
        if (!_observers.Contains(observer))
            _observers.Add(observer);
        return new Unsubscriber(_observers, observer);
    }

    private class Unsubscriber(List<IObserver<VideoEncodedEventArgs>> observers, IObserver<VideoEncodedEventArgs> observer) : IDisposable
    {
        private readonly List<IObserver<VideoEncodedEventArgs>> _observers = observers;
        private readonly IObserver<VideoEncodedEventArgs> _observer = observer;

        public void Dispose()
        {
            if (_observer != null && _observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }

    public async Task Encode(string videoTitle, int durationInSeconds)
    {
        var startTime = DateTimeOffset.Now;
        Console.WriteLine($"[VideoEncoder]: Encoding video '{videoTitle}' for {durationInSeconds} seconds...");

        await Task.Delay(durationInSeconds * 1000);
        var endTime = DateTimeOffset.Now;

        // emit the event to all observers when finished
        var eventArgs = new VideoEncodedEventArgs(videoTitle, durationInSeconds, endTime);
        foreach (var observer in _observers)
        {
            try
            {
                observer.OnNext(eventArgs);
            }
            catch (Exception ex)
            {
                observer.OnError(ex);
            }
            await Task.Delay(1000);
        }

        // This is the piece plain 'event' has NO equivalent for: explicitly telling every subscriber the stream is done.
        foreach (var observer in _observers)
        {
            observer.OnCompleted();
        }
    }
}
