using Observer.Observable.Observables;
using Observer.Observable.Observers;

namespace Observer.Observable;

/*
 Using IObservable and IObserver interfaces for the Observer pattern.
 - IObservable represents the publisher/observable.
 - IObserver represents the subscriber.

 Best usage is for streams of values over time
 Foundation of Reactive Extensions (Rx.NET), which adds LINQ-style operators for filtering, transforming, and combining those streams.
*/
internal class Program
{
    private static async Task Main(string[] args)
    {
        // 1 publisher
        var encoder = new VideoEncoder();

        // 2 subscribers
        var emailService = new NotificationService("Email");
        var outlookService = new NotificationService("Outlook");

        // Register subscribers with the publisher
        emailService.Subscribe(encoder);
        outlookService.Subscribe(encoder);

        // Start encoding a video
        await encoder.Encode("MyVideo", 5);

        // Test unsubscribing the email service so it no longer receives notifications
        emailService.Unsubscribe();
        await encoder.Encode("MyVideo2", 3);
    }
}