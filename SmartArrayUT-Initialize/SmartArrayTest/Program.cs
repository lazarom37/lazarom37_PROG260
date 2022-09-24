using SmartArrayLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SMART_ARRAY_SIZE = 5;

            SmartArray mySmartArray = new SmartArray(SMART_ARRAY_SIZE);

            mySmartArray.SetAtIndex(3, 333);
            mySmartArray.SetAtIndex(4, 444);
            int total = mySmartArray.GetAtIndex(3) + mySmartArray.GetAtIndex(4);
            Console.WriteLine("Hope this comes out as 777!   {0}", total);
            Console.WriteLine();
            Console.WriteLine();
            mySmartArray.PrintAllElements();
            Console.WriteLine();
            bool yes = mySmartArray.Find(333);
            Console.WriteLine("There is a 333 value in the array? {0}", yes);

           
           
            Console.ReadLine();
        }
    }
}
