using System;

namespace sortLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strLabel = {
                                        "A","B","C","D","E","F","G","H","I","J","K","L","M",
                                        "N","O","P","Q","R","S","T","U","V","W","X","Y","Z",
                                };
            LinkedList list = new LinkedList();
            for (int index = 0; index < 100; index++)
            {
                list.InsertNode(strLabel[new Random().Next(0, 26)]);
            }
            list.SortLinkedList();
            Console.WriteLine(list);
            return;
        }
    }
}
