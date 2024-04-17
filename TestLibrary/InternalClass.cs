﻿namespace TestLibrary;

internal class InternalClass
{
    private void PrivateMethod()
    {
        Console.WriteLine("InternalClass.PrivateMethod");
    }

    private int PrivateProperty => 1;

    private int PrivateAutoProperty { get; set; }
}

public class SecondClass
{
    private int _field;

    private int Property { get; set; }

    private int Method()
    {
        _field = 69;
        Console.WriteLine(_field);
        return 0;
    }
}
