// C# dilinde ReactiveExtensions (Rx) kütüphanesinde yer alan bu interfaceleri bir nesnenin durumunda meydana gelen
// değişiklikleri başka nesnelere haber vermek için sergilediğimiz gözlemleme ve gözlemci desenini uygulamak için kullanılan
// yapılardır. Loosely coupled durumu söz konusudur.

MyObservable observable = new();

using var sub1 = observable.Subscribe(new MyObserver("A")); 
using var sub2 = observable.Subscribe(new MyObserver("B")); 
using var sub3 = observable.Subscribe(new MyObserver("C")); 

observable.NotifyObservers(5);
observable.NotifyObservers(7);

class MyObservable : IObservable<int>
{
    private List<IObserver<int>> _observers = new();
    public IDisposable Subscribe(IObserver<int> observer)
    {
        if (!_observers.Contains(observer))
        {
            _observers.Add(observer);
        }

        return new UnSubscription(() =>
        {
            _observers.Remove(observer);
            observer.OnCompleted();
        });
    }

    public void NotifyObservers(int value)
        => _observers.ForEach(observer => observer.OnNext(value));
}

class UnSubscription(Action unSubscription) : IDisposable
{
    public void Dispose()
    {
        unSubscription?.Invoke();
        unSubscription = null;
    }
}

class MyObserver(string observerName) : IObserver<int>
{
    public void OnCompleted()
    {
        Console.WriteLine($"Takibi tamamladı : {observerName}");
    }

    public void OnError(Exception error)
    {
        Console.WriteLine($"Observer hata : {observerName}");
    }

    public void OnNext(int value)
    {
        Console.WriteLine($"Observer : {value} : {observerName}");
    }
}