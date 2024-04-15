// Static Anonymous Functions lambda expressionlarla alakalı bir özelliktir. Lambda expression yapısal olarak bir
// temsilci tarafından işaretlenmesi gereken metodun boilerplate olarak imzasının ve gövdesinin tanımlanmasından biz
// developer'ı kurtaran ve hızlı şekilde ilgili fonksiyonu oluşturarak daha düzgün ve estetik bir şekilde kodun
// geliştirilmesini sağlayan yapılardır.

// İşte bu developer açısından oldukça avantaj sağlayan yapılar esasında bellek optimizasyonu açısından oldukça maliyetli olabilmetedirler.



internal class Program
{
    private static int a;
    private int d;
    
    delegate void XHandler();
    public static void Main(string[] args)
    {
        XHandler handler = new(XX);
        XHandler handlerLambda = new XHandler(() =>
        {

        });

        const int c = 5; // Const yapılanması da kullanılabilir.
        
        Action action = static () => // Bu şekilde maliyetleri törpülemiş oluruz.
        {
            a = 10;
            //d = 20; Static memberın içinde sadece static değişken olabilir.
        };
    }

    static void XX()
    {
        
    }
}