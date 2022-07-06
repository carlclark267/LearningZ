using LearningZ.CS.ClassAccessModifiers;
    
class Program
{
    static void Main(string[] args)
    {
        PrintHeader("ClassAccessModifiers Start");

        AccessingPublicVariables();
        
        PrintHeader("ClassAccessModifiers End");
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

    private static void AccessingPublicVariables()
    {
        PrintHeader("AccessingPublicVariables()");
        
        PersonClass person = new PersonClass();

        int minAge = person.MinAge; // <-- Public property, access via instance of class.
        int middleAge = PersonClass.MiddleAge;  // <-- Static public property, accessed via class not instance.
        int maxAge = PersonClass.MaxAge;    // <-- Const public, access via class not instance.

        Console.WriteLine($"minAge = {minAge}, middleAge = {middleAge}, maxAge = {maxAge}, ");
    }
}