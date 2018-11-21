using System;

namespace sortLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.InsertNode("Lewis");
            list.InsertNode("Ciaran");
            list.InsertNode("James");

            Node n1 = list.InsertNode("Jessica");
            list.InsertNode("Alex");
            
            Console.WriteLine(list);
            list.DeleteNode();
            Console.WriteLine(list);
            list.DeleteNode(new Node("James"));
            Console.WriteLine(list);
            list.SortLinkedList();
            Console.WriteLine(list);
            return;
        }
    }
}
