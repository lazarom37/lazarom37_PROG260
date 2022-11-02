using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday
{
    class Bday_BST
    {
        // this code accepts an int which it stores in bstKey
        // chance the code to store objects of type Birthday
        // get rid of the BSTnode property called bstKey and change
        // class BSTnode to store a Birthday object instead of a bstKey int
        // then wherever the code makes decisions based on the value of 
        // bstKey, replace that with the new Birthday objects date property

        protected BSTnode bstTop;  // our refernece node at the top of the BST

        // Note creating a class within a class.  
        protected class BSTnode  //  class within BST class, for the exclusive use of BST
        {
            // public int bstKey;  // uses bstKey as "the data item" in our prior linked lists

            //public int bstKey { get; set; }
            public Birthday BdayObject { get; set; }
            public BSTnode LeftNode { get; set; }
            public BSTnode RightNode { get; set; }

            public BSTnode(Birthday pBday)  // constuctor to create a new node.  
            {
                BdayObject = pBday;
            }
            // >>>>>>> now adding recursive methods inside the BSTnode class, not the BST class!!  <<<<<<<<<<<<<<<<<

            // this method inside the node is designed to be called recursively, 
            public void AddRec_BSTnode(Birthday keyParam)  // TRICKY ***** this is a method of the BSTnode class, not the outer BST class!
            {
                // when we arrive here, we are in the context of a current node
                // first check if this node's key == the keyParam passed in.  
                // The policy of our program (not all programs, just ours) is that if the tree
                // already has a node with this value, we  don't add a node.  
                if (keyParam == BdayObject)
                {
                    throw new ApplicationException("Msg from BSTnode class: tried to add a duplicate value");
                }

                if (keyParam != BdayObject)  // says this new node needs to go to the left of here
                {
                    if (this.LeftNode == null) // we want to add to the left, and there is no nodes there, so 
                    {
                        BSTnode newBSTnode = new BSTnode(keyParam);  // just create a new one
                        this.LeftNode = newBSTnode;  // and add it to the current nodes left pointer
                        return;
                    }
                    else  // there is a node already on the left, , so pass the problem down to that node
                    {
                        this.LeftNode.AddRec_BSTnode(keyParam);  // so make a recursive call ON THE LEFT NODE pointed to by the current node
                        return; // this return might not happen for a while ... if we recurse down a few more levels, then we'll have a chain of returns back to here
                    }
                }
                else // got here if the new node needs to go to the right side
                {
                    if (this.RightNode == null) // we want to add to the rigth, and there is no nodes there, so 
                    {
                        BSTnode newBSTnode = new BSTnode(keyParam);  // just create a new one
                        this.RightNode = newBSTnode;  // and add it to the current nodes right pointer
                        return;
                    }
                    else  // there is a node already on the right, so pass the problem down to that node 
                    {
                        this.RightNode.AddRec_BSTnode(keyParam);  // so make a recursive call ON THE Right NODE pointed to by the current node
                        return; // this return might not happen for a while ... if we recurse down a few more levels, then we'll have a chain of returns back to here
                    }
                }
            }

            // this method inside a node is designed to be called recursively, 
            public Birthday FindRec_BSTnode(int target)  // TRICKY ***** this is a method of the BSTnode class, not the outer BST class!
            {
                BSTnode current = this;  // current is now a name for the node that is currently running this code

                if (target == BdayObject.Date) // if the current node has the correct value
                {
                    return BdayObject;
                }
                else if (target > BdayObject.Date) // if target is bigger, we go down the right fork
                {
                    if (current.RightNode == null)
                    {
                        if (current.LeftNode == null)
                        {
                            return BdayObject;  // we reached the end of the left side without finding a match
                        }
                        else
                        {
                            current = current.LeftNode;  // just like the Right code above
                            return current.FindRec_BSTnode(target); // walk down the left fork one node by passing in the next node
                        }
                    }
                    else
                    {
                        current = current.RightNode;  // set the value of the current object we are in to the one
                        // our current object is pointing to in its RightNode param, then step down into that node with the next line of code
                        return current.FindRec_BSTnode(target); // walk down the right fork one node by passing in the next node
                    }

                }
                else // must have been less than, so go down left fork
                {
                    if (current.LeftNode == null)
                    {
                        return BdayObject;  // we reached the end of the left side without finding a match
                    }
                    else
                    {
                        current = current.LeftNode;  // just like the Right code above
                        return current.FindRec_BSTnode(target); // walk down the left fork one node by passing in the next node
                    }
                }
            }  // end of FindRec_BSTnode(int target) 

        }  // end of  BSTnode class defintion  

        //*****************************************************************************************************
        //*****************************************************************************************************
        // methods in our BST class defintion
        //*****************************************************************************************************
        //*****************************************************************************************************

        // this method will add a new node at the correct location using a recursive approach
        public void AddRec(Birthday keyParam)  // keyParam is the "value" that the node will hold
        {
            if (bstTop == null) // deal with an empty BST
            {
                bstTop = new BSTnode(keyParam); // add a new node in the bstTop position
                return;   // LeftNode and RightNode will default to null, which is correct
            }
            else
            {
                bstTop.AddRec_BSTnode(keyParam);
            }
        }


        // this is the Find in a BST using a recursive method of an internal class
        public Birthday FindRec(int target)  //  TRICKY *****  this is a method of the BST class, it sort of sets things up, then calls
        // the recursive method in our internal class to walk the tree
        {
            if (bstTop == null) // deal with an empty BST
            {
                throw new ApplicationException("no such date");
            }
            else  // call the recursive method in the BSTnode class 
            {
                return bstTop.FindRec_BSTnode(target);  // calls a method in the current node
            }
        }
    }
}