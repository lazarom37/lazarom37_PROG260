using System;

namespace BST_remove_HW
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Major { get; set; }
        public Student(int pID, string pName, string pMajor)
        {
            ID = pID;
            Name = pName;
            Major = pMajor;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BST myBST = new BST();
            Student student2 = new Student(22, "Lee", "SoftEng");
            Student student4 = new Student(44, "Sue", "Econ");
            Student student3 = new Student(33, "Bill", "Music");
            Student student1 = new Student(11, "Ahmed", "Biology");
            Student student5 = new Student(55, "Xiu", "SoftEng");
            Student student6 = new Student(66, "Tejas", "EngLit");
            myBST.Add(student2);
            myBST.Add(student4);
            myBST.Add(student3);
            myBST.Add(student1);
            myBST.Add(student5);
            myBST.Add(student6);
            myBST.Print();
            Console.WriteLine("added 6");
            Console.WriteLine();

            Console.WriteLine("removed 22");
            myBST.Remove(student2.ID);
            myBST.Print();
            Console.WriteLine();

            Console.WriteLine("removed 33");
            myBST.Remove(student3.ID);
            myBST.Print();
            Console.WriteLine();

            Console.WriteLine("removed 66");
            myBST.Remove(student6.ID);
            myBST.Print();

            Console.WriteLine();

        }
    }
}
