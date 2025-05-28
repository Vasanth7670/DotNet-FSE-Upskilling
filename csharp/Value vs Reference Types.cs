using System;

class Program
{
    struct ValueTypeSample { public int X; }
    class ReferenceTypeSample { public int X; }

    static void ModifyValue(ValueTypeSample v) => v.X = 100;
    static void ModifyReference(ReferenceTypeSample r) => r.X = 100;

    static void Main()
    {
        ValueTypeSample val = new ValueTypeSample { X = 10 };
        ReferenceTypeSample refObj = new ReferenceTypeSample { X = 10 };

        ModifyValue(val);
        ModifyReference(refObj);

        Console.WriteLine($"Value Type: {val.X}"); // 10
        Console.WriteLine($"Reference Type: {refObj.X}"); // 100
    }
}
