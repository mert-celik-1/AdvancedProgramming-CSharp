// Reflction runtime'da proje içerisindeki herhangi bir türün (class,interface,struct,enum,delegate vs.) bilgilerine
// erişme ve bu bilgileri manipüle etme yeteneği sağlayan bir özelliktir. 

// Assembly uygulamaya karşılık gelen ya da uygulamanın derlenmiş ve neticesinde .dll dosyası oluşturulmuş hali olarak nitelendirilir.
// Ayrıca Assembly sınıfı üzerinden farklı bir assembly'de ki bilgileri de inceleyebilirsiniz. Bunun için Load("projenin adı")
// fonksiyonunun kullanılması yeterlidir. ExecutingAssembly kodun mevcutta çalıştığı EntryAssembly ise başlangıç projeyi ifade eder.

using System.Reflection;

//Assembly assembly = Assembly.Load("Proje");   // başka bir proje yükleme
Assembly assembly = Assembly.GetExecutingAssembly();
var types = assembly.GetTypes();

// Module bir assembly içerisinde kullanılan .dll dosyalarıdır. Projeyi başka bir projede refere etmemiz buna örnektir.
Assembly assembly2 = Assembly.GetExecutingAssembly();
var modules = assembly2.GetModules();

// Type
MyClass m = new(); m.GetType(); // 1.yöntem
var type = typeof(MyClass); // 2.yöntem
assembly.GetType(nameof(MyClass)); // 3.yöntem

// Property okuma ve yazma
type.GetMember(nameof(MyClass.X));
type.GetProperties();
PropertyInfo property = type.GetProperty(nameof(MyClass.X));

property.SetValue(m,123);

var valueA = property.GetValue(m);

// Metot çalıştırma
MethodInfo methodInfo = type.GetMethod(nameof(MyClass.Y));
methodInfo.Invoke(m, new object[] { 3 });


class MyClass
{
    public int X { get; set; }

    public void Y(int a) => Console.WriteLine("test..." + a);
}


