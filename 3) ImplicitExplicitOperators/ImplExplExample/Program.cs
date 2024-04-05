// Aynı türden olmayan değişkenleri birbirine atamak için dönüşüm yapmak gereklidir.

// Implicit Conversion : Bir verinin kendi türünden olmayan veri türüne atama sürecinde otomatik olarak dönüştürülmesini ifade eder.
// Küçük sayısal veri türlerini büyük veri türüne atama işlemi implicit bir davranıştır.
// int = short ;  int = byte; long = int; float=long;

// Explicit Conversion : Bir verinin kendi türünden olmayan farklı bir veri türünden değişkene atanma sürecinde iradeli (developer tarafından) dönüştürülmesini ifade eder.
// A = (A)B
// Büyük sayısal verilerde de iradeli bir şekilde bu durum cast işlemi sayesinde gerçekleşebilir.
// short = (short) int ; byte = (byte) int ; int = (int) long ; long (long) float

// Kendi özel türlerimizde bu dönüşümler operator overloading sayesinde yapılır.

Console.WriteLine("Test");


class MyClass
{
    public class A
    {
        public int Price { get; set; }
    }

    public class B
    {
        public int Price { get; set; }

        public static implicit operator A(B instance)
        {
            return new()
            {
                Price = instance.Price
            };
        }
    }

    A a1 = new B(); // Dönüşüm explicit olursa bu deklarasyon hatalı olur. Cast edilmesi gerekir.
    A a2 = (B)new B();

}
