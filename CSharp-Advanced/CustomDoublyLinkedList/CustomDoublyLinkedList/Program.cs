using System;

namespace CustomDoublyLinkedList
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            DoublyLinkedList myLinkedList = new DoublyLinkedList();

            myLinkedList.AddFirst(2);
            myLinkedList.AddFirst(1);
            myLinkedList.AddLast(3);
            myLinkedList.AddLast(4);
            myLinkedList.AddLast(5);
            myLinkedList.RemoveFirst();
            myLinkedList.RemoveLast();

            myLinkedList.ForEach(n => Console.WriteLine(n));
        }
    }
}
