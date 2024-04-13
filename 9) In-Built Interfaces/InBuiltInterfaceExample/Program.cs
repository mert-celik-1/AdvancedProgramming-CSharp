#region IComparer
// IComparer interface'i iki nesneyi karşılaştırmak için kullanılan bir arayüzdür
/*var p1 = new Person() { Name = "Ahmet", Age = 50 };
var p2 = new Person() { Name = "Mehmet", Age = 5 };
var p3 = new Person() { Name = "Ali", Age = 15 };

List<Person> persons = new() { p1, p2, p3 };
persons.ForEach(p=>Console.WriteLine(p.Name));
Console.WriteLine("******");
persons.Sort(new AgeComparer());
persons.ForEach(p=>Console.WriteLine(p.Name));

AgeComparer comparer = new();
var result = comparer.Compare(p1, p2);

class AgeComparer : IComparer<Person>
{
    public int Compare(Person? x, Person? y)
    {
        return x.Age.CompareTo(y.Age);
    }
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}*/
#endregion
#region IComparable
// İki nesnenin karşılaştırılabilir olduğunu belirtmek için kullanılır.

/*
var p1 = new Person() { Name = "Ahmet", Age = 50 };
var p2 = new Person() { Name = "Mehmet", Age = 5 };

var result = p1.CompareTo(p2);
class Person : IComparable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }

    public int CompareTo(Person? other)
    {
        return Age.CompareTo(other.Age);
    }
}*/
#endregion
#region ICloneable
// Nesnenin kopyalanabilir olduğunu belirtmek için kullanılan arayüzdür

/*var p1 = new Person() { Name = "Ahmet", Age = 50 };
var p2 = (Person)p1.Clone();

class Person : ICloneable
{
    public string Name { get; set; }
    public int Age { get; set; }
    
    public object Clone()
    {
        //return this.MemberwiseClone();
        return new Person()
        {
            Age = Age,
            Name = Name
        };
    }
}*/
#endregion
#region INotifyPropertyChanged
// Bir sınıfın property değerleri değiştiğinde bu değişiklikleri dışarıyla bildirmek için kullanılmaktadır.
// Genelde kullanıcı arayüzünde otomatik güncelleme sağlamak amacıyla kullanılan data binding senaryolarında tercih edilir.

/*
using System.ComponentModel;

Person p1 = new() { Name = "Mert" };
p1.PropertyChanged += (sender, e) =>
{
    Console.WriteLine($"Prpoerty {e.PropertyName} changed");
};

p1.Age = 23;
p1.Age = 25;
p1.Age = 27;

class Person : INotifyPropertyChanged
{
    public string Name { get; set; }
    private int age;
    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            age = value;
            PropertyChanged(this, new PropertyChangedEventArgs(nameof(Age)));
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}
*/

#endregion
#region IDisposeble
// Bellek yönetimi için kullanılır. Bu interface ile using bloklarını kullanabiliriz.
/*
class MyDatabase : IDisposable
{
    public object SqlConnection { get; set; }

    public MyDatabase(object sqlConnection)
    {
        SqlConnection = sqlConnection;
    }
    public void Dispose()
    {
        SqlConnection = null;
        GC.SuppressFinalize(this);
    }
}
*/

#endregion