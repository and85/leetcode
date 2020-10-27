using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Test3();

            Console.ReadLine();
        }

        private static void Test1()
        {
            Trie trie = new Trie();

            trie.Insert("apple");
            trie.Search("apple");   // returns true
            trie.Search("app");     // returns false
            trie.StartsWith("app"); // returns true
            trie.Insert("app");
            trie.Search("app");     // returns true
        }

        private static void Test2()
        {
            Trie trie = new Trie();
            trie.Insert("app");
            trie.Insert("apple");
            trie.Insert("beer");
            trie.Insert("add");
            trie.Insert("jam");
            trie.Insert("rental");
            trie.Search("apps");
            trie.Search("app");
        }

        private static void Test3()
        {
            Trie trie = new Trie();
            trie.Insert("ab");
            trie.Insert("ab");
            trie.Insert("abc");
            trie.Search("abc");
            trie.StartsWith("abc");
        }
    }
}
