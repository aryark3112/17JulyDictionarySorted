using System;
using System.Collections.Generic;


namespace _17JulyCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array List
            //ArrayList arrayList = new ArrayList()
            //{ 1,"Sam", 'A',DateTime.Now};
            //Console.WriteLine("item \t Datatype");
            //foreach(var item in arrayList)
            //{
            //    Console.WriteLine(item+"\t"+item.GetType());
            //}
            //ArrayList nameList = new ArrayList()
            //{ "Raj","Ravi","Amit"};
            //Console.WriteLine("Name List as follows");
            //foreach (var item in nameList)
            //{
            //    Console.WriteLine(item);
            //}
            //nameList.Add(12);
            //nameList.Add(DateTime.Now);
            //Console.WriteLine("Name List as Follows");
            //foreach (var item in nameList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();

            //Generic Collection List Example

            //Dictionary Example
            Dictionary<int, string> students = new Dictionary<int, string>()
            {
                {15, "Sam" },
                {12, "Amit" },
                {53, "Raj" }
            };
            Console.WriteLine("Number of students are:"+students.Count);
            Console.WriteLine("Roll \t Name");
            foreach(var k in students.Keys)
            {
                Console.WriteLine(k+ "\t" + students[k]);
            }
            students.Add(32, "Deep");
            Console.WriteLine("Updated Students List");
            Console.WriteLine("Roll \t Name");
            foreach (var k in students.Keys)
            {
                Console.WriteLine(k + "\t" + students[k]);
            }
            Console.ReadKey();
        }
    }
}
