using StackClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOurStack
{
    class Program
    {
        static void Main(string[] args)
        {
            OurStack myStack = new OurStack(4);  // build a short stack, easier to test edge conditions
            
            // students write program that asks for a word, then 
            // tells if was an Palindrome or not.

            // good words:  rotator  deified  reviver  civic  kayak  level  radar  tenet

            // algo:
            // split the letters into a char array
            // push the letters into our stack so can read them in reverse order
            // compare left to rigth [] with right to left (stack.Pop)
            // count of success will = length of word if success
        }

    }
}