using LearningZ.CS.Strings;

class Program
{
    static void Main(string[] args)
    {
        PrintHeader("Strings Start");

        Substring();
        SubstringFail();
        LeftStringExtension();

        PrintHeader("Strings End");
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

    private static void Substring()
    {
        PrintHeader("Substring()");
        string phrase = "Hello World";
        string newPhrase = phrase.Substring(0, 5);
        Console.WriteLine($"Substring(0, 5) of '{phrase}' = '{newPhrase}'");
    }

    private static void SubstringFail()
    {
        PrintHeader("SubstringFail()");
        string phrase = "HW";
        string? newPhrase = null;
        try
        {
            newPhrase = phrase.Substring(0, 5);
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine($"ArgumentOutOfRangeException was raised due to the Substring parameters being outside the size of the string.");
        }
        Console.WriteLine($"Substring(0, 5) of '{phrase}' = '{newPhrase}'");
    }

    private static void LeftStringExtension()
    {
        PrintHeader("Left()");
        string? phrase = "Hello World";

        string? newPhrase = phrase.Left(1);
        Console.WriteLine($"Left(1) of '{phrase}' = '{newPhrase}'");

        newPhrase = phrase.Left(5);
        Console.WriteLine($"Left(5) of '{phrase}' = '{newPhrase}'");

        newPhrase = phrase.Left(50);
        Console.WriteLine($"Left(50) of '{phrase}' = '{newPhrase}'");

        phrase = null;
        newPhrase = phrase.Left(5);
        string phraseOutput = phrase == null ? "null" : phrase;
        string newPhraseOutput = newPhrase == null ? "null" : newPhrase;
        Console.WriteLine($"Left(5) of '{phraseOutput}' = '{newPhraseOutput}'");
    }
}

