using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartArrayLibrary
{
    public class SmartArray
    {
        int[] UnderlyingArray; // using the C# simple array to hold our data

        public SmartArray(int origSize)  // constructor sets initial size
        {
            UnderlyingArray = new int[origSize];
        }

        public void SetAtIndex(int index, int val)
        {
            if (index < 0) 
            {
                throw new IndexOutOfRangeException("underflow");
            }
            else if (index > UnderlyingArray.Length - 1)
            {
                throw new IndexOutOfRangeException("overflow");
            }
            else
            {
                UnderlyingArray[index] = val;
                return;
            }
        }

        public int GetAtIndex(int index)
        {
            try
            {
                return UnderlyingArray[index];
            }
            catch (Exception)
            {

                if (index < 0)
                {
                    throw new IndexOutOfRangeException("underflow");
                }
                else if (index > UnderlyingArray.Length - 1)
                {
                    throw new IndexOutOfRangeException("overflow");
                }
            }
            finally
            {
                
            }
            return Int32.MinValue;
        }

        public void PrintAllElements()
        {
            for (int i = 0; i < UnderlyingArray.Length; i++)
            {
                Console.WriteLine(UnderlyingArray[i]);
            }
        }

        public bool Find(int val)
        {
            for (int i = 0; i < UnderlyingArray.Length; i++)
            {
                if (UnderlyingArray[i] == val)
                {
                    return true;
                }
            }
            return false;
        }

       
    }  // end of SmartArray class
}

