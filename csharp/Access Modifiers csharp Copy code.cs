using System;

class MyClass
{
    public int PublicValue = 1;
    private int PrivateValue = 2;
    protected int ProtectedValue = 3;

    public void ShowValues()
    {
        Console.WriteLine($"Inside MyClass - Public: {PublicValue}, Private: {PrivateValue}, Protected: {ProtectedValue}");
    }
}

class DerivedClass : MyClass
{
    public void ShowInherited()
    {
        Console.WriteLine($"Inside DerivedClass - Public: {PublicValue}, Protected: {ProtectedValue}");
        // PrivateValue is not accessible here
    }
}

class NonDerivedClass
{
    public void TryAccess()
    {
        MyClass obj = new MyClass();
        Console.WriteLine($"NonDerivedClass - Public: {obj.PublicValue}");
        // obj.PrivateValue and obj.ProtectedValue are inaccessible
    }
}

class Program
{
    static void Main()
    {
        var baseObj = new MyClass();
        baseObj.ShowValues();

        var derived = new DerivedClass();
        derived.ShowInherited();

        var other = new NonDerivedClass();
        other.TryAccess();
    }
}
