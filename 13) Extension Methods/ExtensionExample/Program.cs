// Class ve struct yapılarını modify etmeden ilgili struct yada class'için extension metodlar eklememizi sağlar.

/*Extesion metod yazarken uymamız gereken bir kaç kural vardır. Bunlar;

Extension metodlar static bir class içerisinde static olarak tanımlanmalıdır. 
    Extend edilecek class ilgili extension metoda metodun ilk parametresi olarak verilip önünde this keyword'ü ile tanımlanmalıdır
Extension metod da tanımlı parametrelerden sadece 1 tanesi this keyword'ü ile tanımlanır */

Console.WriteLine("Hello, World!");

MyClass m = new();
m.X();

class MyClass
{
    
}

static class ExtensionMethods
{
    public static void X(this MyClass i)
    {
        
    }
}
