public class FracionalKnapsack
{
    /*
    Given weights and values of N items, 
    put these items in a knapsack of capacity W to get the maximum total value in the knapsack. 
    In other words, given two integer arrays val[0..N-1] and wt[0..N-1] which represent values 
    and weights associated with N items respectively. 
    Also given an integer W which represents knapsack capacity, find out the maximum value subset of 
    val[] such that the sum of the weights of this subset is smaller than or equal to W. 
    You CAN break an item
    */
    public static double KnapSack(int W, int[] wt, int[] val, int n)
    {
        var ratio = new (int Wt, int Val, double Ratio)[val.Length];
        for (int i = 0; i < val.Length; i++)
        {
            ratio[i] = (wt[i], val[i], (double)(val[i]) / wt[i]);
        }

        Array.Sort(ratio, new RatioComparer());

        int totalWeight = 0;
        double totalSum = 0;

        int j = 0;
        while (totalWeight < W && j < val.Length)
        {
            int remainingWeight = W - totalWeight;
            if (ratio[j].Wt <= remainingWeight)
            {
                // take the whole item
                totalWeight += ratio[j].Wt;
                totalSum += ratio[j].Val;
            }
            else
            {
                totalWeight = W;
                totalSum += ratio[j].Ratio * remainingWeight;
            }

            j++;
        }

        return totalSum;
    }

    class RatioComparer : IComparer<(int Wt, int Val, double Ratio)>
    {
        public int Compare((int Wt, int Val, double Ratio) x, (int Wt, int Val, double Ratio) y)
        {
            // Compare the Ratio values of x and y and return a value indicating their relative order
            if (x.Ratio > y.Ratio)
            {
                return -1;
            }
            else if (x.Ratio < y.Ratio)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}