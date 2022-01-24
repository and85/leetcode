public class Solution 
{
    public int CountBalls(int lowLimit, int highLimit) 
    {
        var boxes = new Dictionary<int, int>();
        for (int ball = lowLimit; ball <= highLimit; ball++)
        {
            int box = GetBoxNum(ball);
            if (boxes.ContainsKey(box))
            {
                boxes[box]++;
            }
            else
            {
                boxes.Add(box, 1);
            }
                
        }

        return boxes.Values.Max();
    }

    private int GetBoxNum(int ball)
    {
        int box = 0;
        // 321

        while (ball != 0)
        {
            box += ball % 10;
            ball /= 10;
        }

        return box;
    }
}