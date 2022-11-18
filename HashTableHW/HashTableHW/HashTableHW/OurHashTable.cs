using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableHW
{
    public class OurHashTable
    {

        LinkedList<Student>[] hashTable;  //  array holds values
        int tableSize;
        // constructor --- user specifies how big the table they want to use
        public OurHashTable(int pSize)
        {
            hashTable = new LinkedList<Student>[pSize];
            tableSize = pSize;
        }

        public void AddItem(Student value)
        {
            int hashedKey;  // the "human readable" key gets hashed it into this value using the division method below
            hashedKey = HashMul(value.SID);
            Student newNode = value;
            if (hashTable[hashedKey] == null)  // null value means this slot is empty, so we can write our data (now a string) here.
            {
                hashTable[hashedKey] = new LinkedList<Student>();
            }
            else
            {
                Console.WriteLine("  <<< collision  at hashKey" + hashedKey + " with user key " + value.SID); // else this spot was used, we will loose this data!
            }
            hashTable[hashedKey].AddFirst(newNode);
            Console.WriteLine();
        }

        public Student GetItem(int SID)  // notice has fast a look up is!
        {
            int hashedKey;
            hashedKey = HashMul(SID);
            if (hashTable[hashedKey] == null)
            {
                return new Student();
            }
            else
            {
                for (int i = 0; i < hashTable[hashedKey].Count; i++)
                {
                    if (hashTable[hashedKey].ElementAt(i).SID == SID)
                    {
                        return hashTable[hashedKey].ElementAt(i);
                    }
                }
            }
        }

     

        // this is our key hashing algorithm, (using multiply) we could repalce this with other ones to try them out
        public int HashMul(int key)
        {
            double Multiplier = .6180339887;  // must be > 0 but less than 1
            // Knuth suggests .6180339887 Multiplier 
            double dblKey = key; // convert the int key into a double precision floating point
            double percent = Multiplier * dblKey;
            percent = percent - (int)percent; // get the fractional part
            return (int)(Math.Floor(percent * tableSize)); // round down to make sure you have a number that is within the table size
        }

    }
}

