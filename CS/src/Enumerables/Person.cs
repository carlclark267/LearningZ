namespace LearningZ.CS.Enumerables
{
    public class Person
    {
        public Person(string firstName, string lastName, int age)
        {
            Console.WriteLine($">>> Person(\"{firstName}\", \"{lastName}\", \"{age}\")");
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
