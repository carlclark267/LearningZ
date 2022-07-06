class Program
{
    static void Main(string[] args)
    {
        PrintHeader("Guids Start");

        GuidDefaults();

        PrintHeader("Guids End");
    }

    private static void PrintDividingLine()
    {
        Console.WriteLine("----------------------------------------------------------------");
    }

    private static void PrintHeader(string header)
    {
        PrintDividingLine();
        Console.WriteLine($"{header}");
        Console.WriteLine($"{string.Join("", Enumerable.Repeat('-', header.Length))}");
    }

    private static void GuidDefaults()
    {
        PrintHeader("GuidDefaults()");
        Guid emptyGuid = Guid.Empty;
        Console.WriteLine($"emptyGuid = {emptyGuid}");

        Guid newGuid = Guid.NewGuid();
        Console.WriteLine($"newGuid = {newGuid}");

        Guid? nullGuid = null;
        Console.WriteLine($"nullGuid = {nullGuid}, nullGuid.GetValueOrDefault() = {nullGuid.GetValueOrDefault()}");

        if (nullGuid.HasValue)
        {
            Console.WriteLine($"nullGuid has value.  nullGuid.Value = {nullGuid.Value}");
        }
        else
        {
            Console.WriteLine($"nullGuid does NOT have value.");
        }

        nullGuid = Guid.Empty;
        if (nullGuid.HasValue)
        {
            Console.WriteLine($"nullGuid has value.  nullGuid.Value = {nullGuid.Value}");
        }
        else
        {
            Console.WriteLine($"nullGuid does NOT have value.");
        }

        if (!nullGuid.HasValue || nullGuid.Value == Guid.Empty)
        {
            Console.WriteLine($"nullGuid does not have value or is empty");
        }
    }
}