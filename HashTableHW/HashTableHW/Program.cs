using System;
using System.Collections.Generic;

namespace HashTableHW
{

    public class Student
    {
        public int SID { get; set; }
        public string Name { get; set; }
        public string Major { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random myRNG = new Random();
            string[] nameArray = new string[11] {"empty by design", "Ella", "Joseph", "Cameron", 
                "Bethany", "Luke", "Holly", "Courtney", "Caitlin", "William", "Jake", };
            string[] majorArray = new string[3] { "Software", "History", "Biology" };
            List<Student> theList = new List<Student>();
            for (int i = 1; i <= 10; i++)
            {
                theList.Add(new Student { SID = i + 1000, Name = nameArray[i], Major = majorArray[myRNG.Next(0, 3)] });
            }

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"{theList[i].SID} {theList[i].Name} {theList[i].Major} ");
            //}

            OurHashTable myHashTable = new OurHashTable(7);

            for (int i = 0; i < 10; i++)
            {
                myHashTable.AddItem(theList[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 1; i <= 10; i++)
            {
                Student thisStudent = myHashTable.GetItem(i + 1000);
                Console.WriteLine($"{thisStudent.SID} {thisStudent.Name} {thisStudent.Major} ");
            }

        }
    }
}
