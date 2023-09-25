// Mevcut operatorlerin davranışlarını kendi türlerimize özel bir şekilde biçimlendirmek için kullanılır


#region Ornek #1

Student student = new();
Book book = new();

var result = student + book;

class Student
{
    public List<Book> Books { get; set; }
}
class Book
{
    public static Student operator +(Student student, Book book) // Diğer ilgili classta da bu overloading yapılabilirdi. Bu iki class dışında bir classta yapılamaz.
    {
        student.Books.Add(book);
        return student;
    }
}
#endregion


// Hangi Operatörlere Overloading Uygulanır ?
// (+,-,*,/,%) , (++,--) , (true,false), (==,!=,<,>,<=), (explicit,implicit) , (&,^,<<) ...   

// Hangi Operatörlere Overloading Uygulanmaz ?
// &&, indexer[], += , nameof , new...

// İkili beyan gerektiren operatörler : > < , == != , true false, >= <=
// Bunlardan birine operator uygulanırsa zıttına karşılık gelecek bir tanımlama da yapılmalıdır.

// ++ veya -- operatörleri tekil bir parametreyle tanımlanmak zorundadırlar.

// true ve false operatörlerinde geri dönüş değeri boolean olmak zorundadır.