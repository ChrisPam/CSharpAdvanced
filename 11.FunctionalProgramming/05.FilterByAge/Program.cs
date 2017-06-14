using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        Dictionary<string, int> names = new Dictionary<string, int>();
        for (int i = 0; i < n; i++)
        {
            var row = Console.ReadLine()
                .Split(new char[] { ',', ' ' },
                StringSplitOptions.RemoveEmptyEntries);
            var name = row[0];
            var age = row[1];
            names[name] = int.Parse(age);
        }

        var result = new Dictionary<string, int>();

        var condition = Console.ReadLine();
        var delimiterAge = int.Parse(Console.ReadLine());
        var format = Console.ReadLine();

        Func<int, bool> tester = CreateTester(condition, age);
        Action<KeyValuePair<string, int>> printer = CreatePrinter(format);
        PrintFilteredStudent(people, tester, printer);
    }

    public static Func<int, bool> CreateTester(string condition, int age)
    {
        switch (condition)
        {
            case "younger": return x => x < age;
            case "older": return x => x > age;
            default: return null;
        }
    }

    public static Action<KeyValuePair<string, int>> CreatePrinter(string format)
    {
        switch (format)
        {
            case "name":
                return person => Console.WriteLine($"{person.Key}");
            case "age":
                return person => Console.WriteLine($"{person.Value}");
            case "name age":
                return person =>
                Console.WriteLine($"{person.Key} – {person.Value}");
            default: return null;
        }
    }
}