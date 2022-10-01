using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurQueueClass
{
    class Program
    {
        static void Main(string[] args)
        {
            OurQueue myQ = new OurQueue(4);  // using Q size of just 4 to make testing limits easier

            Cust cust1 = new Cust { Balance = 30, Name = "Bill" };
            myQ.Enqueue(cust1);
            Cust cust2 = new Cust { Balance = 40, Name = "Sue" };
            myQ.Enqueue(cust2);
            Cust cust3 = new Cust { Balance = 50, Name = "Lee" };
            myQ.Enqueue(cust3);

            Cust current = myQ.Dequeue();
            Console.WriteLine("hello " + current.Name + " you have $" + current.Balance);

            //modify q class to work with 

            Console.ReadLine();  // done


        }
    }
}
