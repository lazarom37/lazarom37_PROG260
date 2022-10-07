using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLL
{

    public class Student
    {
        public int SID { get; set; }
        public string Name { get; set; }
        public string Major { get; set; }

        public Student(int pSID, string pName, string pMajor)
        {
            SID = pSID;
            Name = pName;
            Major = pMajor;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StudentLinkedList myLL = new StudentLinkedList();



            myLL.InsertAtFront(new Student(1, "Joe", "Physics"));  // insert 1st node
            myLL.InsertAtFront(new Student(2, "Lee", "Music"));  // insert 1st node
            myLL.InsertAtFront(new Student(3, "Susan", "Software Engineering"));  // insert 1st node
            myLL.Print();
            Console.WriteLine();
            Console.WriteLine();

            Student aStudent = myLL.RemoveFromEnd();
            Console.WriteLine("Just removed " + aStudent.Name);
            Console.WriteLine();
            myLL.Print();
            Console.WriteLine();

            aStudent = myLL.RemoveFromEnd();
            Console.WriteLine("Just removed " + aStudent.Name);
            Console.WriteLine();
            myLL.Print();
            Console.WriteLine();

            aStudent = myLL.RemoveFromEnd();
            Console.WriteLine("Just removed " + aStudent.Name);
            Console.WriteLine();
            myLL.Print();
            Console.WriteLine();

            try
            {
                aStudent = myLL.RemoveFromEnd();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            myLL.Print();

            Console.ReadLine();
        }
    }


    class StudentLinkedList
    {
        protected LinkedListNode frontOfList;
        // No constructor, but an undefined object has the value null; which is our flag that the list is empty

        
        
        // *******************  Homework code is to make this method work  *****************
        public Student RemoveFromEnd()
        {
            // remove these 2 lines and provide the correct code
            Student returnVal;
            if (frontOfList == null)
            {
                throw new IndexOutOfRangeException("Linked list is empty");
            }
            else if (frontOfList.node_next_pointer == null)
            {
                returnVal = frontOfList.studentObject;
                frontOfList = null;
            }
            else
            {
                LinkedListNode current = frontOfList; 
                while (current.node_next_pointer.node_next_pointer != null) 
                {
                    current = current.node_next_pointer;
                }
                returnVal = current.node_next_pointer.studentObject;
                LinkedListNode lastNode = current.node_next_pointer;
                current.node_next_pointer = null;
                lastNode = null;
            }
            return returnVal;
        }

        public void InsertAtFront(Student value)
        {
            LinkedListNode newNode = new LinkedListNode(value);  // create new node

            newNode.node_next_pointer = frontOfList; // make this new first node 
            //point to what was previously the first node;
            // if the List had been empty, then we just made the newNode point to "null", which says there is no 2nd node.

            frontOfList = newNode; // change the "reference" to front of list to point to this new one, which itself now points to the prior front of list
        }

        public Student RemoveFromFront()  // returns the "value" that the list object stores, in this case, an int
        {
            Student returnVal;
            if (frontOfList == null)
            {
                throw new IndexOutOfRangeException("list is empty");
            }
            else
            {
                returnVal = frontOfList.studentObject; // get the data from the node at the front of the list

                frontOfList = frontOfList.node_next_pointer;  // copy the front of
                                                              //list's node's pointer to the next node, into the front of List
                                                              // if there was not another node, we just copied a null into the pointer, which says the list is now empty
            }
            return returnVal;
        }

        public void Print()
        {
            // The four steps in the "Linked List Traversal" schema are:
            // 1.Setup
            // 2.Iteration Logic
            // 3.Work (that is done at each iteration)
            // 4.Teardown (anything that happens after the iteration)

            // a simple 'list traversal' schema, 
            // just start at top, grab one, use it, then use its pointer to change the current one to the next one.

            LinkedListNode current = frontOfList;     // 1.Setup
            while (current != null)                   // 2.Iteration Logic
            {
                Console.WriteLine(current.studentObject.Name); // 3.Work (done at each iteration)
                current = current.node_next_pointer;      // 2.Iteration Logic
            }
            // 4.Teardown (anything that happens after the iteration)
        }

        public Student FindByValue(int target)
        {
            LinkedListNode current; // pointer to walk LL

            current = frontOfList;  // start pointer off at top of LL
            while (current != null)  // note that if LL was empty, this still works
            {
                if (current.studentObject.SID == target)  // look into the node object's student object
                {
                    return current.studentObject;  // we found it, return the student object
                }
                current = current.node_next_pointer; // otherwise, move down list
                                                     // note if current was pointing to last node, then its node_next_pointer is null
                                                     // so when we get back up to top of while loop, we will leave loop and return not found
            }
            // if we make it to here, then no such SID found
            Student notFound = new Student(0, "No Such", "No Such");
            return notFound;
        }

public Student RemoveByValue(int target) // return student object if found, empty student object if not
{
    // deal with condition if list is empty, if it is empty,
    // create a new student object setting Name to “no such” and
    // return the new student object (alternatively, we could have thrown an exception)
    if (frontOfList == null)
    {
        Student notFound = new Student(0, "No Such", "No Such");
        return notFound;
    }
    // create a current pointer variable and set it to frontOfList
    LinkedListNode current = frontOfList; // pointer to walk LL

    // if SID value is found in the first node's student object,
    // change the frontOfList contents to effectively remove that node
    // by copying the Name of NextNode Obj from the top entery into the frontOfList, making it now point to 
    // the 2nd node, or null if there was none.  Return that top node’s student object

    if (current.studentObject.SID == target)
    {
        frontOfList = current.node_next_pointer;
        return current.studentObject;
    }

    // else list was not empty, and the first item was not the one we wanted

    //already checked 1st one, need to look past current one to next one to see if that’s the one. As we need to
    //change the pointer on the node BEFORE the one we remove, so we want current to point to node just before it
    // if we got this far, then current is pointing to the top node and we will use the top node to "worm" thru
    // to the next node.


    // do a while loop, where it exits if the current node’s pointer to the next node sees
    // that the next node is null, which indicates we are at bottom of list  in the while loop 

    while (current.node_next_pointer != null)
    {
        // if the current node’s pointer sees that the next node has the value we are looking for, 
              
        if (current.node_next_pointer.studentObject.SID == target)
        {
            // found the node (current next) with the student object we want

            // save the value we want to return
            Student returnValue = current.node_next_pointer.studentObject;

            // re-wire the current node’s next pointer to point to the node AFTER the next node, which will
            // which will leave the node following the current node disconnected as an orphan.
            current.node_next_pointer = current.node_next_pointer.node_next_pointer;
            // and return the student object  (found it)
            return returnValue;
        }

        current = current.node_next_pointer;
        // if not, move the pointer, current, to the next node
        // the value might be null, which is ok, our while loop we detect we are done
    }

    // if walked the entire list and did not find, create a new student object setting Name
    // to “no such” and return the new student object (alternatively, we could have thrown an exception)
    Student notFound2 = new Student(0, "No Such", "No Such");
    return notFound2;
}
        protected class LinkedListNode
        {
            //Property holds "data"
            public Student studentObject { get; set; }
            //public int node_data;
            //Property holds reference pointer, which is next node in the list
            public LinkedListNode node_next_pointer { get; set; }


            //Constructor: node_next_pointer property is set to null by default      
            public LinkedListNode(Student value)
            {
                studentObject = value;
            }
        } // end of nested class definition


    }
}
