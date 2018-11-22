using System;
using System.Collections.Generic;
using System.Text;

namespace sortLinkedList
{
    class Node : IComparable
    {
        public string Name { get; set; }    //Data saved by the node
        public Node Next { get; set; }      //Next node in the list
        public Node Prev { get; set; }      //Previous node in the list

        /// <summary>
        /// Constructor for a Node
        /// </summary>
        /// <param name="name"></param>
        public Node(string name) =>
            Name = name;

        /// <summary>
        /// Compare nodes data using IComparable interface
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            Node node = (Node) obj;
            if (Name[0] > node.Name[0])
                return 1;
             else if(Name[0] == node.Name[0])
                return 0;
             else
                return -1;
        }//CompareTo

        public override string ToString()
        {
            return Name;
        }
    }//Class

}//Namespace
