using System;
using System.Collections.Generic;

public class Program
{
    const int initPageSize = 5;
    public static void Main()
    {
        List<string> elements = new List<string> { };
        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        Random random = new Random();
        int size = 100;
        while (elements.Count < size)
        {
            char[] stringChars = new char[4];

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            elements.Add(new String(stringChars));
        }
        List<string> distinctElements = new List<string>(new HashSet<string>(elements));
        List<string> filteredList = new List<string> { };
        Console.WriteLine("Elements All");
        
        displayList(distinctElements);
        foreach (string s in distinctElements)
        {
            if (!s.StartsWith("Z"))
            {
                filteredList.Add(s);
            }

        }
        Console.WriteLine("Elements All");
       
        displayList(filteredList);
        Console.WriteLine("Enter desired page:");
        int desiredPage = int.Parse(Console.ReadLine());
        Console.WriteLine("page " + desiredPage);
        Console.ReadKey();
        displayList(getPage(filteredList, desiredPage, initPageSize));


    }

    public static List<string> getPage(List<string> collection, int pageNumber, int pagesize)
    {
        int startElemntIndex = pageNumber * pagesize;
        Console.WriteLine("startIndex " + startElemntIndex);
       
        int lastelemntIndex = startElemntIndex + pagesize;
        Console.WriteLine("endIndex " + lastelemntIndex);
       
        Console.WriteLine("count " + collection.Count);
        
        if (lastelemntIndex > collection.Count) { pagesize = collection.Count % pagesize; }
        if (startElemntIndex >= collection.Count) { Environment.Exit(1); return null; }
        else
            return collection.GetRange(startElemntIndex, pagesize);

    }

    public static void displayList(List<string> list)
    {
        foreach (string s in list)
        {
            Console.WriteLine(s);
            


        }
    }
}