using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksUsingDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();

            if (myStack.Count == 0)
                Console.WriteLine("Stack started out empty");
            else
                Console.WriteLine("Somethings wrong, stack started out NON empty?");
          

            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            if (myStack.Count == 0)
                Console.WriteLine("Stack empty after 3 pushes!");
            else
                Console.WriteLine("Stack contains stuff after 3 pushes!");       

            int x = (int)myStack.Peek();
            Console.WriteLine("top most element is {0}", x);


            x = (int)myStack.Pop();
            Console.WriteLine("top most element WAS {0}, but we just removed it", x);

           
            x = (int)myStack.Pop();
            Console.WriteLine("next elementremoved is {0}", x);

            Console.WriteLine("Stack contains {0} item after removing 2 items!", myStack.Count);

            x = (int)myStack.Peek();
            Console.WriteLine("And that last element still on the stack is {0}", x);

            Console.ReadLine();
        }

        
    }
}
  