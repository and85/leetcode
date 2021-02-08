using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList myLinkedList = new MyLinkedList();
            myLinkedList.AddAtHead(2);
            myLinkedList.DeleteAtIndex(1);
            myLinkedList.AddAtHead(2);
            myLinkedList.AddAtHead(7);
            myLinkedList.AddAtHead(3);
            myLinkedList.AddAtHead(2);
            myLinkedList.AddAtHead(5);
            myLinkedList.AddAtTail(5);
            myLinkedList.Get(5);
            myLinkedList.DeleteAtIndex(6);
            myLinkedList.DeleteAtIndex(4);


            Console.ReadLine();
        }
    }
}
