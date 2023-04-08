using System;


public class Suitcase : ICloneable
{
    public string Brand { get; set; }
    public string Color { get; set; }
    public int Size { get; set; }

    public object Clone()
    {
        
        return MemberwiseClone();
    }

    public override string ToString()
    {
        return $"Brand: {Brand}, Color: {Color}, Size: {Size}";
    }
}


public class SuitcaseBuilder
{
    private Suitcase _suitcase;

    public SuitcaseBuilder()
    {
        _suitcase = new Suitcase();
    }

    public SuitcaseBuilder SetBrand(string brand)
    {
        _suitcase.Brand = brand;
        return this;
    }

    public SuitcaseBuilder SetColor(string color)
    {
        _suitcase.Color = color;
        return this;
    }

    public SuitcaseBuilder SetSize(int size)
    {
        _suitcase.Size = size;
        return this;
    }

    public Suitcase Build()
    {
        
        return _suitcase;
    }
}