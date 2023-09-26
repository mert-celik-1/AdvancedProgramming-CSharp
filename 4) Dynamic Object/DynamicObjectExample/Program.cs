using System.Dynamic;

// Dynamic obje oluşturarak runtimede tip belirtmeden obje yönetebiliriz.

#region  Activator Sınıfı ile Nesne Oluşturma
MyClass m = (MyClass)Activator.CreateInstance(typeof(MyClass));
#endregion

#region DynamicObject ile Nesne Oluşturma

dynamic instance = new MyClass();
instance.prop1 = 123;
instance.prop2 = "124";

#endregion


#region dynamic Keywordü ile Nesne Oluşturma

dynamic obj = new ExpandoObject();
obj.prop1 = 123;
obj.prop2 = "124";

#endregion

class MyClass : DynamicObject
{
	public MyClass()
	{
		Console.WriteLine($"{nameof(MyClass)} instance created");
	}

    readonly private Dictionary<string, object> properties = new();

    public override bool TrySetMember(SetMemberBinder binder, object? value)
    {
        properties.Add(binder.Name, value);
        return true;
    }

    public override bool TryGetMember(GetMemberBinder binder, out object? result)
    {
        return properties.TryGetValue(binder.Name, out result); 
    }

}