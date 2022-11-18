using HeapHomework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog260_Heap
{

    public class Node  // our basic node object, _ReservationNumber used for maintaining the tree
    {
        public string nodeText { get; set; }  // for this example, our object will hold a single text string
        public int ReservationNumber { get; set; }  // this property holds the "value", the priority key

        public Node(int value, string pTextString)  //  constuctor
        {
            ReservationNumber = value;
            nodeText = pTextString;
        }
    }

    public class Heap
    {
        // Note, even though our storage array will start at 0, we will not use that location. 
        // So node indexes start at 1
        private Person[] heapArray;  // the storage that holds are heap
        private int maxSize;       // keep track of how big we are
        private int currentSize;   // keep track of how many entries we have

        public Heap(int creationSize)  // Constuctor, takes in the size user spec's for max size
        {
            maxSize = creationSize;  // set the maximum value
            currentSize = 0;         // set the heap to empty
            heapArray = new Person[maxSize + 1];  // instantiate the array, per the size 
            // (we are not going to use the zero element, as it makes the math statements simpler)
        }

        public bool IsEmpty  // property indicated empty heep
        {
            get
            {
                return currentSize == 0;  // will be true or false
            }
        }

        //*********************************************************************************************************
        //*********************************************************************************************************
        //*********************************************************************************************************

        public bool Insert(Person newNode)  // method to insert a new node, returns true if successful
        {
            if (currentSize == maxSize)  // fail if we are full  (could have an array expansion routine instead)
                return false;

            currentSize++; // bump up the count of entries
            heapArray[currentSize] = newNode;  // add the new node at the very bottom
            CascadeUp(currentSize);  // check to see if we need to swap this up higher and higher
            return true;
        }

        public void CascadeUp(int index)  // index is a pointer in the array ::: but that also makes it a pointer to the node object
        {
            // we use this 2 ways.  
            // [1] if we just added a node to the bottom and we need to possbily bubble it up to where it belongs
            // [2] if we changed the value of a node anywhere in the tree,
            //    we tested if this nodes new value means it must cascaded up


            // general idea is: for whereever our current index is pointing, check if its value is bigger than its parent.
            // If it is, swap them, and then, check the new higher spot for the same thing, and cascasde up until it is under
            // a node that is larger than it is.

            int parentPointer = (index) / 2;  // simple way to always calc your parent loc in array
            Person NodeToBubbleUp = heapArray[index]; // create a new node object = to the one at the bottom

            //now walk up (by changing the pointer, index) until either you reach the top, or you find
            // a parent that is bigger than you are

            while (index > 1 && heapArray[parentPointer].ReservationNumber < NodeToBubbleUp.ReservationNumber)
            {
                heapArray[index] = heapArray[parentPointer]; //new node must be bigger than parent, so copy parent
                                                             // node value down to where index is
                                                             // at which point the parent and child are ==, and the child data is overwritten,
                                                             // but you have it when you saved it at the very beginning as NodeTOBubbleUp

                index = parentPointer; // move the lower node pointer up one level
                parentPointer = (parentPointer) / 2;   // move the parentPointer up one level
                // and loop again
            }

            // when we leave the loop either the node above you is bigger, or you are at the top of the tree
            // so you overwrite that parent (which you has just pushed a copy of down to your child before you got here)
            // with that copy we made on the new node

            heapArray[index] = NodeToBubbleUp;

        }

        //*********************************************************************************************************
        //*********************************************************************************************************
        //*********************************************************************************************************

        public Person RemoveMaxNode() // Remove maximum value node
        {
            Person root = heapArray[1];  // well, we have what we wanted!, but, we need to fix up the tree too
            heapArray[1] = heapArray[currentSize--]; // copy the very last node up to the root to overwrite the root
                                                     // AND decrease the total size, which deletes that last node
            CascadeDown(1);  // and then deal with the fact that the node we grabbed from the bottom
                             // probably doesn't belong on top
            return root;
        }

        public void CascadeDown(int index)  // 
        {
            // we use this 2 ways.  
            // [1] if we just removed the top node, we copied a bottom node to the top, and we need to bubble it down
            // to its correct location.
            // [2] if we changed the value of a node anywhere in the tree,
            //    we tested if this nodes new value means it must cascaded down.
            //
            // to do this, Look at its left and right children, then move it down (swap it)
            // with the LARGER of its 2 children.
            // Because you just picked the larger of the 2 children, you know the one you
            // just swapped up one level is safely larger than what used to be it’s peer
            // so the one swapped UP will be ok, as its larger than the unswapped child, and by definition,
            // its larger than the child you just did the swap to.
            // Then you need to recurse, and see if the node that got pushed down is bigger than its new kids, etc. 
            // until either its “good” or there are no more children under it.
            // after you do a swap, and we write the child up to the parent, we don't actually write the 
            // NodeToBubbleDown into the child spot, we just 


            int largerChild; // a semiphore, "note" to tell us which child is bigger
            Person NodeToBubbleDown = heapArray[index]; // make a copy of the node that we may be bubbling down
            while (index <= currentSize / 2)  // if we are not at the bottom, 
            {
                // get pointers to our 2 childen
                int leftChildPointer = 2 * index;
                int rightChildPointer = 2 * index + 1;

                // decide which of our 2 childred are the biggest  (make sure there is a right child too)
                if (rightChildPointer <= currentSize && heapArray[leftChildPointer].ReservationNumber < heapArray[rightChildPointer].ReservationNumber)
                    largerChild = rightChildPointer;
                else
                    largerChild = leftChildPointer;
                if (NodeToBubbleDown.ReservationNumber >= heapArray[largerChild].ReservationNumber) // what if we are Bigger or Same Size than largest child?
                    break; // then get out of the loop, we found where we need to stay

                // if not, then we copy our bigger child up to be the new parent node where index is now,
                heapArray[index] = heapArray[largerChild];

                index = largerChild;  // and walk down one level (either right or left) to where the larger child was

                // and loop to do it all again
            }

            // we get out of the loop if either
            //  a) we did the "break" as we are at the level where NodeToBubbleDown is larger than both children, or
            //  b) index node is now on the bottom row,

            heapArray[index] = NodeToBubbleDown; // so whatever node position index is at now, we write in
                                                 // the contents of the node we started off with to bubble down
        }

        //*********************************************************************************************************
        //*********************************************************************************************************
        //*********************************************************************************************************




        public void DisplayHeap() // write out all values and content and then draw a pic of the heap structure
        {
            // this is just some cool math that uses the known layout of the array to write out the heap.
            Console.WriteLine();
            Console.Write("Elements of the Heap Array are : ");
            for (int m = 1; m <= currentSize; m++)
                if (heapArray[m] != null)
                    Console.Write(heapArray[m].ReservationNumber + "-" + heapArray[m].FirstName + " ");
                else
                    Console.Write("-- ");
            Console.WriteLine();
            int emptyLeaf = 32;
            int itemsPerRow = 1;
            int column = 0;
            int j = 1;
            String separator = "...............................";
            Console.WriteLine(separator + separator);
            while (currentSize > 0)
            {
                if (column == 0)
                    for (int k = 0; k < emptyLeaf; k++)
                        Console.Write(' ');
                Console.Write(heapArray[j].ReservationNumber);

                if (++j == currentSize + 1)
                    break;
                if (++column == itemsPerRow)
                {
                    emptyLeaf /= 2;
                    itemsPerRow *= 2;
                    column = 0;
                    Console.WriteLine();
                }
                else
                    for (int k = 0; k < emptyLeaf * 2 - 2; k++)
                        Console.Write(' ');
            }
            Console.WriteLine("\n" + separator + separator);
        }
    }
}
