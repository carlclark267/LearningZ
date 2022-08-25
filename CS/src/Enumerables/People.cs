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
            people.Add(new Person("Luke", "Skywalker", 30));
            people.Add(new Person("Han", "Solo", 30));
            people.Add(new Person("R2", "D2", 80));
            people.Add(new Person("Darth", "Vader", 100));
            people.Add(new Person("C3", "PO", 90));
            people.Add(new Person("Anakin", "Skywalker", 35));
            people.Add(new Person("Leia", "Skywalker", 30));
            return people;
        }

        public static IEnumerable<Person> GetPeopleWithYield()
        {
            Console.WriteLine($"People.GetPeopleWithYield()");
            yield return new Person("Luke", "Skywalker", 30);
            yield return new Person("Han", "Solo", 30);
            yield return new Person("R2", "D2", 80);
            yield return new Person("Darth", "Vader", 100);
            yield return new Person("C3", "PO", 90);
            yield return new Person("Thna", "Moo", 5);
            yield return new Person("Anakin", "Skywalker", 35);
            yield return new Person("Leia", "Skywalker", 30);
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
