public class NumberContainers 
{

    private Dictionary<int, int> _indexes = new Dictionary<int, int>();
    private Dictionary<int, SortedSet<int>> _numbers = new Dictionary<int, SortedSet<int>>();    

    public NumberContainers() 
    {
        
    }
    
    public void Change(int index, int number) 
    {
        if (!_indexes.ContainsKey(index))
        {
            _indexes.Add(index, number);
            
            SetNumber(index, number);
        }
        else
        {
            int oldNumber = _indexes[index];
            _numbers[oldNumber].Remove(index);
            
            _indexes[index] = number;            

            SetNumber(index, number);            
        }
    }

    private void SetNumber(int index, int number)
    {
        if (!_numbers.ContainsKey(number))
        {
            _numbers.Add(number, new SortedSet<int>());
        }

        if (!_numbers[number].Contains(index))
        {
            _numbers[number].Add(index);

            
        }
    }

    public int Find(int number)
    {
        if (!_numbers.ContainsKey(number)) return -1;

        return _numbers[number].FirstOrDefault() > 0 ? _numbers[number].FirstOrDefault() : -1;
    }

    
}