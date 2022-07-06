class Program
{
    static async Task Main(string[] args)
    {
        PrintHeader("Lazy Start");
        PrintCredits();

        NoLazyLoading();
        NoLazyLoadingLoadOnce();
        NotLazyLoadingLoadOnce();
        LazyLoadingLoadOnce();
        await LazyLoadingLoadOnceAsync();

        PrintHeader("Lazy End");
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

    private static void PrintCredits()
    {
        PrintHeader("Credits");
        Console.WriteLine("Thank you SingletonSean - https://www.youtube.com/channel/UC7X9mQ_XtTYWzr9Tf_NYcIg");
        Console.WriteLine("Lazy Loading w/ System.Lazy (and async Lazy) - .NET ADVANCED ESSENTIALS - https://www.youtube.com/watch?v=lvRWmTqZbOo");
    }

    private static void NoLazyLoading()
    {
        PrintHeader("NoLazyLoading()");
        Console.WriteLine($"Guid = {GetGuid()}");
        Console.WriteLine($"Guid = {GetGuid()}");
    }

    private static void NoLazyLoadingLoadOnce()
    {
        PrintHeader("NoLazyLoadingLoadOnce()");
        var guid = GetGuid();
        Console.WriteLine($"Guid = {guid}");
        Console.WriteLine($"Guid = {guid}");
    }

    private static void NotLazyLoadingLoadOnce()
    {
        PrintHeader("NotLazyLoadingLoadOnce()");
        Lazy<Guid> guid = new Lazy<Guid>(GetGuid());    // <-- This calls immediately.
        Console.WriteLine($"Guid = {guid}");
        Console.WriteLine($"Guid = {guid}");
    }

    private static void LazyLoadingLoadOnce()
    {
        PrintHeader("LazyLoadingLoadOnce()");
        Lazy<Guid> guid = new Lazy<Guid>(() => GetGuid());
        Console.WriteLine($"Guid = {guid.Value}");
        Console.WriteLine($"Guid = {guid.Value}");
    }

    private static async Task LazyLoadingLoadOnceAsync()
    {
        PrintHeader("LazyLoadingLoadOnceAsync()");
        Lazy<Task<Guid>> guid = new Lazy<Task<Guid>>(() => GetGuidAsync());
        Console.WriteLine($"Guid = {await guid.Value}");
        Console.WriteLine($"Guid = {await guid.Value}");

    }

    private static Guid GetGuid()
    {
        Console.WriteLine(" > GetGuid()");
        Thread.Sleep(3000);
        return Guid.NewGuid();
    }

    private static async Task<Guid> GetGuidAsync()
    {
        Console.WriteLine(" > GetGuidAsync()");
        await Task.Delay(3000);
        return Guid.NewGuid();
    }
}