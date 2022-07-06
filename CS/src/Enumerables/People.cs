using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningZ.CS.Enumerables
{
    public static class People
    {
        public static IEnumerable<Person> GetPeople()
        {
            Console.WriteLine($"People.GetPeople()");
            List<Person> people = new();
            people.Add(new Person("Luke", "Skywalker"));
            people.Add(new Person("Han", "Solo"));
            people.Add(new Person("R2", "D2"));
            people.Add(new Person("Darth", "Vader"));
            people.Add(new Person("C3", "PO"));
            people.Add(new Person("Anakin", "Skywalker"));
            return people;
        }

        public static IEnumerable<Person> GetPeopleWithYield()
        {
            Console.WriteLine($"People.GetPeopleWithYield()");
            yield return new Person("Luke", "Skywalker");
            yield return new Person("Han", "Solo");
            yield return new Person("R2", "D2");
            yield return new Person("Darth", "Vader");
            yield return new Person("C3", "PO");
            yield return new Person("Thna", "Moo");
            yield return new Person("Anakin", "Skywalker");
        }

        public static IEnumerable<Person>? GetPeopleNullList()
        {
            Console.WriteLine($"People.GetPeopleNullList()");
            return null;
        }

        public static IEnumerable<Person> GetPeopleEmptyList()
        {
            Console.WriteLine($"People.GetPeopleEmptyList()");
            return new List<Person>();
        }
    }
}
