
XHandler xdelegate = new XHandler(X);
YHandler ydelegate = Y;
XHandler xdelegete2 = () => { };
XHandler xdelegete3 = delegate() { }; // Temsil etme yöntemleri

// Delegate çağırma
   
xdelegate();
xdelegate.Invoke();


// Multicast Delegate
ZHandler zdelegate = () => Console.WriteLine("1");
zdelegate += () => Console.WriteLine("2");
zdelegate += () => Console.WriteLine("3");
zdelegate += () => Console.WriteLine("4");
zdelegate += () => Console.WriteLine("5");
 

void X()
{
    Console.WriteLine("X metot");
}

(int, char) Y(A a, (string, int) p)
{
    return (3, 'a');
}


public delegate void XHandler(); // Delegate Tanımlama
public delegate (int, char) YHandler(A a, (string, int) p);
public delegate void ZHandler();
public delegate T3 GHandler<T1, T2, T3>(T1 param1, T2 param2); // Generic Delegate Tanımlama



public class A { }








