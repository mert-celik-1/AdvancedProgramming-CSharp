// Covariance ve Contravariance terimleri array types, delegate types, return types ve generic types için
// implicit referans dönüşümlerinin ifade eden özelliklerdir.

// Covariance matematikte iki değişkenin aynı yönlü contravariance ise zıt yönde hareket etmesidir.

// Covariance daha spesifik bir türün daha genel bir türün yerine kullanılabilmesi anlamına gelmektedir

// Örn A B nin parentıdır (class B:A) :
// IEnumerable<B> _b = new List<B>();
// IEnumerable<A> _a = _b;     --> B tipi atası olan A tipine atanabilmektedir.


// Contravariance daha genel bir türün daha spesifik bir türün yerine kullanılabilmesi anlamına gelmektedir.

// Örn A B nin parentıdır (class B:A) :
// void XMethod(A a){}
// Action<A> aDelegate = XMethod;
// Action<B> bDelegate = XMethod;



#region Covariance

//Array Types
object[] x = new string[5];
x[0] = 123; // Tür olarak güvenli değildir. Görüldüğü üzere string olarak tanımladığımız diziye integer değer atayabildik.

class Array
{
    class Animal { }
    class Cat : Animal { }
    IEnumerable<Animal> animals = new List<Cat>();
}


//Delegate Types
class Delegate
{
    class Animal { }
    class Cat : Animal { }
    Func<Animal> getAnimal = GetCat;
    static Cat GetCat() => new();
}


//Return Types
class A
{
    public virtual A X() => new();
}

class B:A
{
    public override B X()
    {
        return new();
    }
}

// Generic Types

class Generic
{

    interface IAnimal<out T>{ }

    class Animal<T> : IAnimal<T>{ }

    class Mammal{ }

    class Cow : Mammal{ }

    IAnimal<object> objectAnimal = new Animal<string>();
    IAnimal<Mammal> objectAnimal2 = new Animal<Cow>();

}

#endregion


#region Contravariance

//Delegate Types
class DelegateT
{
    //Action<A> a = a => { };
    //Action<B> b = a;
}


//Generic Types


class Generic2
{

    interface IAnimal<in T> { }

    class Animal<T> : IAnimal<T> { }

    class Mammal { }

    class Cow : Mammal { }

    IAnimal<string> objectAnimal = new Animal<object>();
    IAnimal<Cow> objectAnimal2 = new Animal<Mammal>();

}

#endregion