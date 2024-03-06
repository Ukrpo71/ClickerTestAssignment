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

    public void IncreaseResource()
    {
        _value += 1;

        ResourceQuantityChanged?.Invoke();
    }

    public event Action ResourceQuantityChanged;

    public string Name => _name;
    public int Value => _value;
}
