// See https://aka.ms/new-console-template for more information
using LearningZ.CS.Enumerables;

class Program
{
    static void Main(string[] args)
    {
        PrintHeader("LearningZ.CS.Enumerables Start");

        PrintPeople();
        PrintPeopleWithYield();
        PrintPersonByFirstNameWithYield("R2!");
        PrintPeopleWhereClause();
        PrintPeopleChainedWhereClause();
        RemoveOneListFromAnother();
        FirstOrDefaultExample();
        FirstOrDefaultEmptyList();
        FirstOrDefaultNullList();
        FirstOrDefaultWhereClauseWithNull();

        PrintHeader("LearningZ.CS.Enumerables End");
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

    private static void PrintPeopleWhereClause()
    {
        PrintHeader("PrintPeopleWhereClause()");
        var people = People.GetPeople().Where(x => x.LastName == "Skywalker");

        foreach (var person in people)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName} = {person.Age}");
        }
    }

    private static void PrintPeopleChainedWhereClause()
    {
        PrintHeader("PrintPeopleChainedWhereClause()");
        var people = People.GetPeople().Where(x => x.LastName == "Skywalker").Where(x => x.Age <= 30);

        foreach (var person in people)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName} = {person.Age}");
        }
    }

    /// <summary>
    /// Demonstrates the handling of FirstOrDefault() with a Linq where clause resulting in an empty list.
    /// </summary>
    private static void FirstOrDefaultWhereClauseWithNull()
    {
        PrintHeader("FirstOrDefaultWhereClauseWithNull()");
        var people = People.GetPeople();
        var filteredPeople = people.Where(person => person.FirstName == "NOT_HERE");
        var another = filteredPeople.ToList();
        var person = filteredPeople.FirstOrDefault();
        if (person != null)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName}");
        }
        else
        {
            Console.WriteLine($"FirstOrDefault() returned null.");
        }
    }

    /// <summary>
    /// Demonstrates the handling of FirstOrDefault on an empty list, i.e., the list must be tested for null before calling FirstOrDefault().
    /// </summary>
    private static void FirstOrDefaultNullList()
    {
        PrintHeader("FirstOrDefaultNullList()");
        var people = People.GetPeopleNullList();
        var person = people?.FirstOrDefault();
        if (person != null)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName}");
        }
        else
        {
            Console.WriteLine($"FirstOrDefault() returned null.");
        }
    }

    /// <summary>
    /// Demonstrates FirstOfDefault() result on an empty list.
    /// </summary>
    private static void FirstOrDefaultEmptyList()
    {
        PrintHeader("FirstOrDefaultEmptyList()");
        var people = People.GetPeopleEmptyList();
        var person = people.FirstOrDefault();
        if (person != null)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName}");
        }
        else
        {
            Console.WriteLine($"FirstOrDefault() returned null.");
        }
    }

    /// <summary>
    /// Demonstrates FirstOfDefault() where a valid item is found in a list.
    /// </summary>
    private static void FirstOrDefaultExample()
    {
        PrintHeader("FirstOrDefaultExample()");
        var people = People.GetPeople();
        var person = people.FirstOrDefault();
        Console.WriteLine($"{person?.FirstName} {person?.LastName}");
    }

    /// <summary>
    /// Attempts to fetch a name from a list using yield and outputs the result.
    /// </summary>
    /// <param name="personFirstName">First name of the person in the list.</param>
    private static void PrintPersonByFirstNameWithYield(string personFirstName)
    {
        var person = FetchPersonByFirstNameYield(personFirstName);
        if (person != null)
        {
            Console.WriteLine($"FetchPersonByFirstName(\"{personFirstName}\") = {person.FirstName} {person.LastName}");
        }
        else
        {
            Console.WriteLine($"Could not find a person with the FirstName: \"{personFirstName}\"");
        }
    }

    /// <summary>
    /// Demonstrates the populating of a list using the yield statement, i.e., only populated on use.
    /// </summary>
    private static void PrintPeopleWithYield()
    {
        PrintHeader("PrintPeopleWithYield()");
        var people = People.GetPeopleWithYield();

        foreach (var person in people)
        {
            Console.WriteLine($"    > Person = {person.FirstName} {person.LastName}");
        }
    }

    /// <summary>
    /// Printing a simple list of people.
    /// </summary>
    private static void PrintPeople()
    {
        PrintHeader("PrintPeople()");
        var people = People.GetPeople();

        foreach (var person in people)
        {
            Console.WriteLine($"    > Person = {person.FirstName} {person.LastName}");
        }
    }

    /// <summary>
    /// Fetches a person from a people list by the first name using a Linq where clause on a yield list.
    /// </summary>
    /// <param name="firstName">First name of the person to fetch.</param>
    /// <returns>A person record or NULL if not found.</returns>
    private static Person? FetchPersonByFirstNameYield(string firstName)
    {
        PrintHeader($"FetchPersonByFirstNameYield({firstName})");
        return People.GetPeopleWithYield().Where(person => person.FirstName == firstName).FirstOrDefault();
    }

    /// <summary>
    /// Generates a new list based on using one list as criteria against another list, i.e., use a list of last names to filter the people list and store the result in a new list.
    /// </summary>
    public static void RemoveOneListFromAnother()
    {
        PrintHeader("RemoveOneListFromAnother()");

        var people = People.GetPeople();

        var listOfLastNames = new List<string>();
        listOfLastNames.Add("Skywalker");
        listOfLastNames.Add("Vader");

        var filteredPeople = people.Where(person => listOfLastNames.Contains(person.LastName));

        foreach (var person in filteredPeople)
        {
            Console.WriteLine($"    > Person = {person.FirstName} {person.LastName}");
        }
    }
}