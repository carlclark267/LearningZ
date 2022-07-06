namespace LearningZ.CS.Enumerables
{
    public class Person
    {
        public Person(string firstName, string lastName)
        {
            Console.WriteLine($">>> Person(\"{ firstName}\", \"{lastName}\")");
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }    
    }
}
