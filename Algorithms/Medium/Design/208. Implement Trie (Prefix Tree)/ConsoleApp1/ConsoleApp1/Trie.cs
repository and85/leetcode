using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Trie
    {
        public class TrieNode
        {
            public TrieNode()
            {
            }

            public TrieNode(char value, bool isWordEnd)
            {
                Value = value;
                IsWordEnd = isWordEnd;
            }

            public char Value { get; set; }
            public List<TrieNode> Children { get; set; } = new List<TrieNode>();

            public bool IsWordEnd { get; set; }
        }

        private TrieNode _root = new TrieNode();

        /** Initialize your data structure here. */
        public Trie()
        {
        }

        /** Inserts a word into the trie. */
        public void Insert(string word)
        {
            char letter;
            TrieNode currNode = _root;
            for (int i = 0; i < word.Length; i++)
            {
                letter = word[i];
                var existingNode = currNode.Children.SingleOrDefault(c => c.Value == letter);
                if (existingNode != null)
                {
                    if(!existingNode.IsWordEnd)
                        existingNode.IsWordEnd = IsWordEnd(word, i);
                    
                    currNode = existingNode;
                }
                else
                {
                    var newNode = new TrieNode(letter, IsWordEnd(word, i));
                    currNode.Children.Add(newNode);
                    currNode = newNode;
                }
            }
        }

        /** Returns if the word is in the trie. */
        public bool Search(string word)
        {
            return Search(word, false);
        }

        /** Returns if there is any word in the trie that starts with the given prefix. */
        public bool StartsWith(string prefix)
        {
            return Search(prefix, true);
        }

        private bool Search(string word, bool startsWith)
        {
            char letter;
            TrieNode currNode = _root;
            for (int i = 0; i < word.Length; i++)
            {
                letter = word[i];
                var existingNode = currNode.Children.SingleOrDefault(c => c.Value == letter);

                if (existingNode == null)
                    return false;

                if (!startsWith && 
                    (!existingNode.IsWordEnd && IsWordEnd(word, i)))
                    return false;

                currNode = existingNode;

            }

            return true;
        }

        private bool IsWordEnd(string word, int i)
        {
            return i == word.Length - 1;
        }
    }
}
