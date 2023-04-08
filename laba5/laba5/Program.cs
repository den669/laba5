class Program
{
    static void Main(string[] args)
    {
        
        var builder = new SuitcaseBuilder();
        var suitcase = builder.SetBrand("Samsonite")
                              .SetColor("Black")
                              .SetSize(24)
                              .Build();
        Console.WriteLine(suitcase);

        var clonedSuitcase = (Suitcase)suitcase.Clone();
        Console.WriteLine(clonedSuitcase);
    }
}