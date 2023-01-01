public class SmallestInfiniteSet {

    private PriorityQueue<int, int> _heap = new PriorityQueue<int, int>();
    private HashSet<int> _set = new HashSet<int>();

    public SmallestInfiniteSet() 
    {
        for (int i = 1; i <= 1000; i++)
        {
            _heap.Enqueue(i, i);
            _set.Add(i);
        }
    }
    
    public int PopSmallest() 
    {
        int min = _heap.Dequeue();
        _set.Remove(min);        

        return min;
    }
    
    public void AddBack(int num) 
    {        
        if (!_set.Contains(num))
        {
            _set.Add(num);
            _heap.Enqueue(num, num);
        }
    }
}