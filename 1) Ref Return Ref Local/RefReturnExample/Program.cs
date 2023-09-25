
// ref keywordu bir metodun parametresine herhangi bir değişkenin değerini değil referansını göndermemizi sağlayan bir keyworddur.
// ref return ise geriye bir referans döndürmemizi sağlar.

#region Ref Kullanımı
int b = 5;
X(ref b);
Console.WriteLine(b);

void X(ref int a)
{
    a = 124;
}
#endregion



#region Return Ref Kullanımı
int d = 5;
ref var e = ref Y(ref d); // Değişkeni tanımlarken ref kullanmak zorunda değiliz. Kullanmazsak atama değer tipinde olur
e = 23;
Console.WriteLine(b); // 23

ref int Y(ref int a)
{
    a = 124;
    return ref a;
}
#endregion

// NOT : Ref return özelliğinin kullanıldığı metotta geri return edilen değişken referansı local olamaz.
// parametre olmasının tek nedeni referans olarak belirtmemizdendir.


#region Return Local Kullanımı
char o = 'a';
ref char p = ref o; // Farklı değişkenlerin aynı referansı işaretlemesini sağlar.
#endregion