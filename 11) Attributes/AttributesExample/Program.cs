Console.WriteLine("....");
// Yazılım elemanlarının davranışına yapılandırmasına veya görünümüne müdahele etmek için kullanılan bir özelliktir.
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
class MyAttribute : Attribute
{
    //Attributelerde sadece propertylere erişim vardır. Bu ctor içerisinde yada düz tanımlanmış property olabilir
    public MyAttribute(int a)
    {
        
    }

    public int b { get; set; }
    
}

[My(5,b=20)]
class MyClass
{
    
}

