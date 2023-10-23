using System.Text;

public class Solution
{
    public static void  RotateRigh(int[] array)   
    {               
        // {1, 2, 3, 4, 5} -> {5, 1, 2, 3, 4 }
        int tail = array[array.Length - 1];

        for (int i = array.Length - 2; i >= 0; i--)
        {
            array[i + 1] = array[i];
        }

        array[0] = tail;                
    }   
}   