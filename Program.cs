using System;
using System.Collections.Generic;
using System.Linq;
namespace lin
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> my_list = new List<string>()  
        { 
                "This is my Dog", 
                "Name of my Dog is Robin", 
                "This is my Cat", 
                "Name of the cat is Mewmew"
        }; 
  
        // Creating LINQ Query 
        var res = from l in my_list 
                  where l.Contains("my") 
                  select l; 
        var resm = my_list.Where(a => a.Contains("Dog")); 
  
        // Executing LINQ Query 
        foreach(var q in res) 
        { 
            Console.WriteLine(q); 
        } 
        foreach(var q in resm) 
        { 
            Console.WriteLine(q); 
        } 
        }
    }
}
