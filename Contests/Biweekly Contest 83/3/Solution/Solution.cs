public class NumberContainers 
{

    private Dictionary<int, int> _indexes = new Dictionary<int, int>();
    private Dictionary<int, HashSet<int>> _numbers = new Dictionary<int, HashSet<int>>();

    private Dictionary<int, int> _minIndexes = new Dictionary<int, int>();

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
            _minIndexes[oldNumber] = FindMinIndex(oldNumber);
        }
    }

    private void SetNumber(int index, int number)
    {
        if (!_numbers.ContainsKey(number))
        {
            _numbers.Add(number, new HashSet<int>());
        }

        if (!_numbers[number].Contains(index))
        {
            _numbers[number].Add(index);

            if (!_minIndexes.ContainsKey(number))
            {
                _minIndexes.Add(number, index);
            }
            else
            {
                int minIndex = _minIndexes[number];
                if (minIndex > index)
                {
                    _minIndexes[number] = index;
                }
            }
        }
    }

    public int Find(int number)
    {
        if (!_minIndexes.ContainsKey(number))
        {
            if (_numbers.ContainsKey(number))
            {
                _minIndexes.Add(number, FindMinIndex(number));                
            }
            else
            {
                return -1;
            }
        }

        return _minIndexes[number];
    }

    private int FindMinIndex(int number)
    {
        int min = int.MaxValue;

        if (!_numbers.ContainsKey(number) || _numbers[number].Count == 0) return -1;

        foreach (var v in _numbers[number])
        {
            min = Math.Min(v, min);
        }

        return min;
    }
}