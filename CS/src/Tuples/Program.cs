class Program
{
    static void Main(string[] args)
    {
        PrintHeader("Tuples Start");

        SimpleTuple();
        SimpleTupleNamedItems();
        ListOfTupleNamedItems();

        PrintHeader("Tuples End");
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

    private static void SimpleTuple()
    {
        PrintHeader("SimpleTuple");
        var tuple = (1, "Hello");
        Console.WriteLine($"tuple.Item1={tuple.Item1} tuple.Item2={tuple.Item2}");
    }
    private static void SimpleTupleNamedItems()
    {
        PrintHeader("SimpleTupleNamedItems");
        (int Id, string Name) tuple = (1, "Hello");
        Console.WriteLine($"tuple.Item1={tuple.Item1} tuple.Item2={tuple.Item2}");
        Console.WriteLine($"tuple.Id={tuple.Id} tuple.Name={tuple.Name}");
    }

    private static void ListOfTupleNamedItems()
    {
        PrintHeader("SimpleTupleNamedItems");
        var tupleList = new List<(int Id, string Name)>();
        tupleList.Add((1, "Hello"));
        tupleList.Add((Id: 2, Name: "World"));

        foreach (var tuple in tupleList)
        {
            Console.WriteLine($"tuple.Item1={tuple.Item1} tuple.Item2={tuple.Item2}");
            Console.WriteLine($"tuple.Id={tuple.Id} tuple.Name={tuple.Name}");
        }
        Console.WriteLine($"tupleList.Count = {tupleList.Count}");

        tupleList.Clear();
        Console.WriteLine($"{Environment.NewLine}tupleList.Cleared, tupleList.Count = {tupleList.Count}");
    }

}