using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurQueueClass
{

    public class Cust
    {
        public string Name { get; set; }
        public int Balance { get; set; }
    }
    public class OurQueue
    {
        private int qTop;
        private int qBottom;
        // is really a pointer to the next unused slot in the array

        int[] ourData; // underlying array to hold the data

        private int counter; // our field to keep track of how many

        public int QCount  // simple property to expose number in queue
        {
            get { return counter; }
            // set do not let outside program change this value
        }




        public OurQueue (int qSize)  // constructor, allow user to pick a reasonable upper limit for size
	    {
            ourData = new int[qSize];  // set the size of the array
            qTop = 0;  // next one to take out --> value makes no sense as queue is empty
            qBottom = 0;  // next unused is top of array
            counter = 0;  // zero makes sense
	    }

     

        public void Enqueue(int newItem)
        {
            if (counter >= ourData.Length) // make sure we have room
            {
                throw new OverflowException("Q is full");
            }
            
            counter++;  // adding one, so up the count on entries
            ourData[qBottom] = newItem;  // put it where our bottom is

            // if we have to wrap around back to the lowest value in array
            if ((qBottom + 1) == ourData.Length)
            {
                qBottom = 0;  // just set bottom back to 0.  We KNOW we have room
            }
            else
            {
                qBottom = qBottom + 1;  // otherwise, just bump it one
            }
        }

public int Dequeue()
{
    if (counter == 0) // make sure there is something to return
    {
        throw new IndexOutOfRangeException("Q is empty");  
        // again, there is no "underflow" exception, so using this one
    }
    int returnValue = ourData[qTop];  // use our pointer to find it
    counter--;    // one less, so adjust count
    // do we need to wrap?
    if ((qTop + 1) == ourData.Length)
    {
        qTop = 0; // yes we do, so move back to the low value of the array
    }
    else
    {
        qTop = qTop + 1; // else just bump it 1
    }
    return returnValue;
}

        public bool IsEmpty()
        {
            if (counter == 0)  // just check the count
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Peek()
        {
            if (counter == 0)
            {
                throw new IndexOutOfRangeException("Q is empty");
            }
            else
	        {
                return ourData[qTop];
	        }
       }

        public void Clear()
        {
            qTop = 0;
            qBottom = 0;
            counter = 0;
        }
    }
}
