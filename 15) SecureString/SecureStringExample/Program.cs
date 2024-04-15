// Teknik olarak uygulamada kullanılan değişkenler memory üzerinde tutulacağı için 3.şahıslar tarafından memorye
// ulaşılıp sistem üzerinde dönen tüm verilerin içeriklerinde gözlem yapabilme ihtimalleri söz konusu olabilir.
// Bu değişkenleri üzerinde manuel manipülasyonlar uygulayarak yapmayı düşünebiliriz ama string ifadeler memory yapılanmasında
// immutable (sabit-değişmez) yapılardır. Yani string bir ifade üzerinde yapılan herhangi bir işlem direkt olarak değişkenin
// bellekteki fiziksel yapısına yansıtılmayacak, ilgili değişkenin bir kopyası oluşturularak onun üzerinde gerçekleştirilecektir.
// Dolayısıyla bu işlem neticesinde memoryde değişkenin eski değerinin olduğu gibi hafızadaki ilgili adreste kaldığını söyleyebiliriz.

using System.Runtime.InteropServices;
using System.Security;

string bankCardNo = "1234 4567 4233 2323";
SecureString secureString = new();
bankCardNo.ToList().ForEach(c=> secureString.AppendChar(c));
secureString.MakeReadOnly();

IntPtr bstr = Marshal.SecureStringToBSTR(secureString);
var value = Marshal.PtrToStringUni(bstr);
Console.WriteLine(value);
