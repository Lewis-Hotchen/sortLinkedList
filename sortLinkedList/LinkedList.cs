using System;
using System.Collections.Generic;
using System.Text;

namespace sortLinkedList
{

    class LinkedList
    {
        public Node First { get; private set; } //First node in the linked list
        public int Count { get; private set; }  //Count of nodes in the list

        /// <summary>
        /// Constructor for linked list
        /// </summary>
        public LinkedList()
        {
            First = null;   //Set it to empty on instantiation of the list
            Count = 0;      //Initialise counter to 0
        }//Constructor

        /// <summary>
        /// Insert a new node to the front of the list
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public Node InsertNode(string data)
        {
            //Create node to be implemented
            Node node = new Node(data);

            node.Next = First;
            //If the list is not empty set the current first's previous node to the new one
            if (First != null)
                First.Prev = node;

            //Set the new node to the first
            First = node;
            Count++;
            return node;
        }//InsertNode

        /// <summary>
        /// Sort the list by alphebetical order
        /// </summary>
        public void SortLinkedList()
        {
            Node targetI;
            Node targetJ;
            Node nodeL;
            Node nodeH;

            targetI = First;
            while (targetI != null)
            {
                if (checkSort())
                    return;

                targetJ = targetI.Next;
                while (targetJ != null)
                {
                    nodeL = targetI;
                    nodeH = targetJ;

                    switch (nodeL.CompareTo(nodeH))
                    {
                        //if NodeL is Higher than NodeH
                        case 1:
                            Node temp = nodeH.Next;
                            if (nodeH.Next == null)  //This means last in list
                            {

                            }
                            else
                            {
                                if (nodeL.Prev == null)   //This means first in list
                                {
                                    //Set first node
                                    First = nodeH;  
                                    //Set the high nodes next node to the new previous
                                    temp.Prev = nodeL;
                                    //Set the low nodes next node to the highs next
                                    nodeL.Next = nodeH.Next;
                                    //Set the low node previous to high node
                                    nodeL.Prev = nodeH;
                                    //Set the high node next to low node
                                    nodeH.Next = nodeL;
                                    //Set the high node previous to null (first in list)
                                    nodeH.Prev = null;
                                    
                                    targetI = targetI.Prev;
                                }//if
                                else
                                {

                                }
                            }//if else
                            break;
                    }
                    targetJ = targetJ.Prev; //Decrement through list
                }//while
                targetI = targetI.Next; //Increment through list
            }//while
        }//sortLinkedList

        /// <summary>
        /// check if the list is sorted
        /// </summary>
        /// <returns></returns>
        private bool checkSort()
        {
            Node temp = First;
            while (temp != null)
            {
                if (temp.Next != null)
                {

                    if (temp.CompareTo(temp.Next) == 1)
                    {
                        return false;
                    }//iff
                    temp = temp.Next;
                }//if
            }//while
            return true;
        }//checkSort

        /// <summary>
        /// Delete last node in the list
        /// </summary>
        /// <returns></returns>
        public Node DeleteNode()
        {
            Node node = First;
            while (node != null)
            {
                if (node.Next != null)
                {
                    node = node.Next;
                }
                else
                {
                    node.Prev.Next = null;
                    node = null;
                }
            }
            Count--;
            return node;
        }//DeleteNode

        /// <summary>
        /// Delete node at specified point (will delete First instance found)
        /// </summary>
        /// <returns></returns>
        public Node DeleteNode(Node link)
        {
            if (link == null)
                return link;

            Node node = First;
            while (node != null)
            {
                if (node.CompareTo(link) == 0)
                {
                    node.Prev.Next = node.Next;
                    node.Next.Prev = node.Prev;
                    node = null;
                }
                else
                {
                    node = node.Next;
                }
            }
            Count--;
            return node;
        }//DeleteNode

        /// <summary>
        /// Insert a node after another specified node
        /// </summary>
        /// <param name="link"></param>
        /// <param name="data"></param>
        public void InsertAfter(Node link, string data)
        {
            if (link == null)
                return;

            Node newLink = new Node(data);
            newLink.Prev = link;
            if (link.Next != null)
            {
                link.Next.Prev = newLink;
            }

            newLink.Next = link.Next;
            link.Next = newLink;
            Count++;
        }//InsertAfter

        /// <summary>
        /// Display contents of list
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            Node node = First;

            StringBuilder sb = new StringBuilder();
            while (node != null)
            {
                sb.Append("[" + node.Name + "]");
                node = node.Next;
            }

            return sb.ToString();
        }//ToString

    }//class

}//namespace
