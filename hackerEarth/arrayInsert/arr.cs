using System;

class arr
{
    public static void Main(string[] args)
    {
        string[] dims = Console.ReadLine().Split(' ');
        int N = Convert.ToInt32(dims[0]);
        int Q = Convert.ToInt32(dims[1]);

        string[] nums = Console.ReadLine().Split(' ');
        int[] numArr = new int[N];

        for (int i = 0; i < nums.Length; i++)
        {
            numArr[i] = Convert.ToInt32(nums[i]);
        }

        for (int q = 0; q < Q; q++)
        {
            string[] qParams = Console.ReadLine().Split(' ');
            if (qParams[0] == "1")
            {
                int swapIdx = Convert.ToInt32(qParams[1]);
                int val = Convert.ToInt32(qParams[2]);
                numArr[swapIdx] = val;
            } else if (qParams[0] == "2")
            {
                int startIdx = Convert.ToInt32(qParams[1]);
                int endIdx = Convert.ToInt32(qParams[2]);
                int sum = 0;
                for (int s = startIdx; s <= endIdx; s++)
                {
                    sum += numArr[s];
                }
                Console.WriteLine(sum);
            }
        }
    }
}