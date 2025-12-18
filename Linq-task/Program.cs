using System;
namespace HelloWorld
{
    public class Person{
        public string name { get; set; }
        public int age { get; set; }
        public string city { get; set; }
    }
    public class PersonDeatails
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Person { age=21,name="jefin",city="tirur"},
                new Person { age=30,name="raseena",city="tirur"},
                new Person { age=26,name="basheer",city="tirur"},
                new Person{ age=11,name="afin",city="tanur"},
                new Person{ age=19,name="Neha",city="Calicut"},

            };
            var result = people.Where(n => n.age > 25&&n.city=="tirur").Select(n => new { n.name, n.age });
            foreach (var person in result)
            {
                Console.WriteLine($"Name: {person.name}, Age: {person.age}");
            }
        }

    }
}