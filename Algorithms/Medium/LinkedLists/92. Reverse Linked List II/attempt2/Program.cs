namespace Attempt2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = new ListNode(1);
            var n2 = new ListNode(2);
            var n3 = new ListNode(3);
            var n4 = new ListNode(4);
            var n5 = new ListNode(5);

            n1.next = n2;
            n2.next = n3;
            n3.next = n4;
            n4.next = n5;

            var solution = new Solution();
            solution.ReverseBetween(n1, 2, 4);

            Console.ReadLine();
        }
    }
}