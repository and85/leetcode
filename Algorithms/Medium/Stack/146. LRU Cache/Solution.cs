/// <summary>
/// not finished implementation which uses a good approach but contains a bug, similar to Solution 2
/// </summary>
public class LRUCache
{

    private int _capacity;
    private Dictionary<int, Node> _dictionary;
    private Node _senitelHead = new Node();
    private Node _senitelTail = new Node();

    class Node
    {
        public Node? Prev { get; set; }
        public Node? Next { get; set; }

        public int Key { get; set; }
        public int Value { get; set; }
    }


    public LRUCache(int capacity)
    {
        _capacity = capacity;
        _dictionary = new Dictionary<int, Node>();
        
        _senitelHead.Next = _senitelTail;
        _senitelTail.Prev = _senitelHead;
    }

    public int Get(int key)
    {
        if (_dictionary.ContainsKey(key))
        {
            var node = _dictionary[key];
            MoveToEnd(node);
            return node.Value;
        }

        return -1;
    }

    public void Put(int key, int value)
    {
        if (_dictionary.ContainsKey(key))
        {
            var node = _dictionary[key];
            node.Value = value;
            MoveToEnd(node);
        }
        else
        {
            var node = new Node();
            node.Key = key;
            node.Value = value;

            var prevTail = _senitelTail.Prev;
            if (prevTail != null)
            {
                prevTail.Next = node;
                node.Prev = prevTail;
                node.Next = _senitelTail;
                _senitelTail.Prev = node;
            }

            if (_dictionary.Count + 1 > _capacity)
            {
                var nodeToDelete = _senitelHead.Next;
                if (nodeToDelete != null)
                {
                    _dictionary.Remove(nodeToDelete.Key);
                }

                _senitelHead.Next = _senitelHead?.Next?.Next;
            }

            _dictionary.Add(key, node);
        }
    }

    private void MoveToEnd(Node node)
    {
        var prev = node.Prev;
        var next = node.Next;

        if (prev != null)
        {
            prev.Next = next;            
        }

        if (next != null)
        {
            next.Prev = prev;
        }

        var prevTail = _senitelTail.Prev;
        if (prevTail != null)
        {
            prevTail.Next = node;
            node.Next = _senitelTail;
            _senitelTail.Prev = node;
        }
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */