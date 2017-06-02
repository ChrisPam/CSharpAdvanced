using System;
using System.Collections.Generic;
using System.Linq;

public class FixEmails
{
    public static void Main()
    {
        var emails = new Dictionary<string, string>();
        var input = Console.ReadLine();
        while (input.ToLower() != "stop")
        {
            var name = input;
            var email = Console.ReadLine();

            emails[name] = email;
            input = Console.ReadLine();
        }

        foreach (var email in emails)
        {
            var mail = email.Value;
            var domain = mail[email.Value.Length - 2].ToString() + mail[email.Value.Length - 1].ToString();

            if (domain != "uk" && domain != "us")
            {
                Console.WriteLine($"{email.Key} -> {email.Value}");
            }

        }
    }
}
