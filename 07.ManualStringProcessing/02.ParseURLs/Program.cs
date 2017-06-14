using System;
using System.Collections.Generic;
using System.Linq;

public class ParseURLs
{
    public static void Main()
    {
        var url = Console.ReadLine();
        var indexOfSlash = url.IndexOf("://");
        if(indexOfSlash < 0)
        {
            Console.WriteLine("Invalid URL");
            return;
        }
        var splitedUrl = url.Split(new string[] { "://" }, StringSplitOptions.None);

        if(splitedUrl.Length > 2)
        {
            Console.WriteLine("Invalid URL");
            return;
        }
        var protocol = splitedUrl[0];
        if (splitedUrl[1].IndexOf('/') < 0)
        {
            Console.WriteLine("Invalid URL");
            return;
        }
        var splitedUri = splitedUrl[1].Split(new char[] { '/' },
            StringSplitOptions.None);
        var server = splitedUri[0];
        Console.WriteLine($"Protocol = {protocol}");
        Console.WriteLine($"Server = {server}");
        var resources = string.Join("/", splitedUri).Substring(server.Length + 1);
        Console.WriteLine($"Resources = {resources}");
    }
}