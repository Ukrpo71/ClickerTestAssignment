using System;

public class Resource
{
    private int _value;
    private readonly string _name;

    public Resource(int value, string name)
    {
        _value = value;
        _name = name;
    }

    public void Increase()
    {
        _value += 1;

        QuantityChanged?.Invoke();
    }

    public event Action QuantityChanged;

    public string Name => _name;
    public int Value => _value;
}
