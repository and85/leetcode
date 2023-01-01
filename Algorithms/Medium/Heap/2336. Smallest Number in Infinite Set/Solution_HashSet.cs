public class SmallestInfiniteSet_HashSet {

    private PriorityQueue<int, int> _heap = new PriorityQueue<int, int>();
    private HashSet<int> _removed = new HashSet<int>();

    public SmallestInfiniteSet_HashSet() 
    {
        
    }
    
    public int PopSmallest() 
    {        
        for (int i = 1; i <= 1000; i++)
        {
            if (!_removed.Contains(i))
            {
                _removed.Add(i);
                return i;
            }
        }

        return 0;
    }
    
    public void AddBack(int num) 
    {        
        if (_removed.Contains(num))
        {
            _removed.Remove(num);
        }
    }
}