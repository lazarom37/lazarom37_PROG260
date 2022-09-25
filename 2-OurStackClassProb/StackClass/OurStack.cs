using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackClass
{
    public class OurStack
    {
        private int iTop;
        int [] ourData;

        public OurStack(int sSize)  // constructor
	    {
            // instead of a counter, we use an array index pointer = -1 to say "empty"
            // so our pointer points to the current top of stack, if it is a zero,
            // then array element 0 holds a valid value which is the top of the stack
            ourData = new int[sSize];
            iTop = -1; // stack is empty
	    }

        public void Push(int item)  // add an item to the stack
        {
            if (iTop == ourData.Length -1)  // this needed the -1
            {
                throw new OverflowException("Stack is full");
            }
            else
            {
                ourData[++iTop] = item;
               
            }
            // if we are already pointing to the last element of the array, so we are full,  throw new OverflowException("Stack is full");
           
             // move our pointer to the next empty aray slot
             // copy the passed in value to the top of the stack (actaully, the highest occupied index of the array)
        }

        public int Pop() // remove and return an item from the stack
        {
            if (iTop < 0)
            {
                throw new IndexOutOfRangeException("Stack is empty");
            }
            else
            {
                return ourData[iTop--];
            }
            // check if stack is empty, if it is,  throw new IndexOutOfRangeException("Stack is empty");
         
           // grab the value of the current top of stack
           // back up the top pointer to what is now the top of the stack
           // return  the Value;
        }

        public bool IsEmpty()
        {
            if (iTop < 0)
            {
                return true;
            }
            return false;
            
        }

        public int Peek()
        {
            if (iTop < 0)
            {
                throw new IndexOutOfRangeException("Stack is empty");
            }
            else
            {
                return ourData[iTop];
            }


       }

        public void Clear()
        {
            // ??
        }
    }
}

