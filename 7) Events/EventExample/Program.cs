// Event bir durumun veya aksiyonun meydana geldiğini takip etmek ve bu olaya karşın tepki vermek amacıyla kullanılan bir özelliktir.
// Delegateler ile birlikte kullanılmaktadır.
// Not : Instance üzerinden delegatelere erişilmez. Nesne üzerinden erişilemez. Eventler üzerinden açılabilir.

MyEventPublisher m = new MyEventPublisher();
m.MyEvent += X;
m.RaiseEvent();

//MyEventPublisher.XHandler xDelegate = new MyEventPublisher.XHandler(X); Bu şekilde delegateye ulaşılabilir.

void X()
{
    Console.WriteLine("Event tetiklendi");
}

class MyEventPublisher
{
    public delegate void XHandler(); 
    public event XHandler MyEvent;

    public void RaiseEvent()
    {
        MyEvent(); // Event fırlatıldı
    }
}

