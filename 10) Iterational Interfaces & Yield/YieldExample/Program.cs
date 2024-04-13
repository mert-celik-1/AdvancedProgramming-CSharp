// IEnumerable bir sınıfa iterasyonel davranış kazandırmamızı sağlayan GetEnumerator metodunu barındıran interfacedir.
// IEnumerator interface'i ise bir sınıfın iterasyonel davranışında hangi kuralların geçerli olacağını belirlemektedir.

using System.Collections;

IEnumerable GetNames()
{
    //List<string> names = new() { "Ahmet", "Mehmet", "Mert" };
    //return names;
    yield return "Mert";
    yield return "Ahmet";
    yield return "Mehmet";
}

class Stock : IEnumerable
{
    private List<string> materials = new() { "kalem", "silgi", "defter" };
    
    IEnumerator IEnumerable.GetEnumerator()
    {
        return new StockEnumerator(materials);
    }
}

class StockEnumerator :  IEnumerator
{
    public void Dispose() => _source = null;
    public bool MoveNext() => ++_currentIndex < _source.Count;
    public void Reset() => _currentIndex = -1;
    
    public StockEnumerator(List<string> source)
    {
        _source = source;
    }

    private List<string> _source;
    private int _currentIndex = -1;

    public object Current => _source[_currentIndex];
}

