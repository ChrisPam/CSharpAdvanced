using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Action<string> printStudent = s => Console.WriteLine(s);
        Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList().ForEach(x => printStudent(x));
    }
    
}
