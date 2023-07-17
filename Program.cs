using System;
using System.Collections;
using System.Collections.Generic;


namespace _17JulyCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList()
            { 1,"Sam", 'A',DateTime.Now};
            Console.WriteLine("item \t Datatype");
            foreach(var item in arrayList)
            {
                Console.WriteLine(item+"\t"+item.GetType());
            }
            ArrayList nameList = new ArrayList()
            { "Raj","Ravi","Amit"};
            Console.WriteLine("Name List as follows");
            foreach (var item in nameList)
            {
                Console.WriteLine(item);
            }
            nameList.Add(12);
            nameList.Add(DateTime.Now);
            Console.WriteLine("Name List as Follows");
            foreach (var item in nameList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}
