using System.Text;

public class Solution
{
    public static void RotateLeft(int[] array)   
    {               
        int head = array[0];

        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }

        array[array.Length - 1] = head;                
    }   
}   