// Static Abstract Members In Interface Nedir ?
// Static Abstract Members In Interface anlayabilmek için öncelikle Static Interface Memberlara odaklanmakta fayda vardır.
// Interface dediğimiz kavram class imzalarıdır. Ayrıca interfaceler Default Implementation özelliği sayesinde içlerinde
// imzaların gövdelerini de barındırabilmektedirler. İşte bizler bu default implementation olarak tanımlanan memberları
// bir yandan da static olarak işaretleyebilmekteyiz. Interface içerisinde tanımlanmış olan herhangi bir member imzası
// özü itibariyle dolaylı olarak abstract davranış sergilemektedir. Benzer şekilde default implementation olarak tanımlanmış
// member ise fıtratı gereği virtual olarak davranış sergileyecektir.Not : Default implementation olan memberlar virtual olmaları
// istenmiyorsa sealed keywordü ile işaretlenmelidir.
// Static keywordü ile işaretlenmiş olan default implementation memberlar ise özü itib ariyle ne abstracttır ne de virtual
// Haliyle sealed ile de işaretlenemez. Lakin C# 11 ile artık static interface memberlar abstract keywordu ile işaretlenebilmektedir.
// ve bu belirli bir davranışın sergilenmesine sebebiyet vermektedir.

// Default implementation static abstract olamaz. Normal imzalar static abstract olabilir ama normal static olamaz.

// Özet olarak static memberları interfaceler aracılığıyla herhangi bir sınıfa zorunlu kılmak istiyorsak eğer StaticAbstractMembers
// özelliği kullanılmaktadır.


IX.C();
X.A();

XX<X> xx1 = new();

class XX<T> where T : IX
{
    public XX()
    {
        T.A();
        T.B(); // C gelmiyor !!! sadece static abstract gelir
    }
}

interface IX
{
    static abstract void A(); // Abstract olmasa static olarak işaretlenemezdi.
    abstract static void B();

    static void C()
    {
        Console.WriteLine("C tetiklendi");
    }
}


class X : IX
{
    public static void A()
    {
        Console.WriteLine("A tetiklendi");
    }

    public static void B()
    {
        Console.WriteLine("B tetiklendi");
    }
}