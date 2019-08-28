using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        #region 1 завдання
        Console.WriteLine("1 завдання");
        Console.ReadKey();
        List<Person> persons = new List<Person> {
        new Person(){name="Roman",age=15,phoneNumbers = new List<string> {"+380999999999","+0353225560"}},
        new Person(){name="Takia",age=51,phoneNumbers = new List<string> {"+3809913323239","+023251560"}},
        new Person(){name="Momo",age=18,phoneNumbers = new List<string> {"+380911111199","+0222222220"}},
        new Person(){name="Mazen",age=25,phoneNumbers = new List<string> {"+380933333399","+0354444440"}},
        new Person(){name="Olga",age=35,phoneNumbers = new List<string> {"+380955555559","+0366666660"}},
        new Person(){name="Vitalik",age=18,phoneNumbers = new List<string> {"+380977777999","+0377888760"}}
        };
        foreach (Person p in persons)
        {
            Console.WriteLine(p.name + " " + p.age);
            Console.ReadKey();

        }
        Console.WriteLine();
        Console.ReadKey();
        #endregion

        #region 2 завдання
        Console.WriteLine("2 завдання");
        Console.ReadKey();
        persons.AddRange(new List<Person>{
        new Person(){name="Olga2",age=32,phoneNumbers = new List<string> {"+380955555524","+0366665510"}},
        new Person(){name="Vitalik2",age=38,phoneNumbers = new List<string> {"+381111777999","+03772222760"}}
        });
        foreach (Person p in persons)
        {
            foreach (string phoneN in p.phoneNumbers)
            {
                Console.WriteLine(phoneN);
                Console.ReadKey();
            }
        }
        #endregion
    }


}

public class Person
{
    public string name { get; set; }

    public int age { get; set; }

    public List<string> phoneNumbers { get; set; }

}