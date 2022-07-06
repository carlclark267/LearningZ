using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        PrintHeader("Async Start");
        PrintListAsync().Wait();
        try
        {
            ThrowExceptionAsync().Wait();
        }
        catch (AggregateException e)
        {
            Console.WriteLine(" > Caught intentional exception from ThrowExceptionAsync()");
            Console.WriteLine($" > {e.GetType()} - {e.Message}");
            if (e.InnerException != null)
            {
                Console.WriteLine($" > {e.InnerException.GetType()} - {e.InnerException.Message}");                
            }
        }
        PrintHeader("Async End");
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

    private static async Task PrintListAsync()
    {
        PrintHeader("PrintListAsync()");
        var list = await GetListTaskRunAsync();
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }

    private static async Task<List<string>> GetListTaskRunAsync()
    {
        return await Task.Run(() =>
        {
            var list = new List<string>();
            list.Add("ListItem 1");
            list.Add("ListItem 2");
            list.Add("ListItem 3");
            return list;
        });
    }

    private static async Task<string> ThrowExceptionAsync()
    {
        return await Task.FromException<string>(new NotImplementedException());
    }
}