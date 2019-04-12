using System;

class play {
  public static void Main(string[] args) {
    string[] longs = Console.ReadLine().Split(' ');
    string[] arr = Console.ReadLine().Split(' ');

    long N = Convert.ToInt64(longs[0]);
    long Q = Convert.ToInt64(longs[1]);
    long[] cumSum = new long[N];
    long[] longArr = new long[N];

    for (long x = 0; x < N; x++) {
      longArr[x] = Convert.ToInt64(arr[x]);
      if (x == 0) {
        cumSum[x] = longArr[x];
      } else {
        cumSum[x] = cumSum[x-1] + longArr[x];
      }
    }

    long[,] lr = new long[Q, 2];

    for (long m = 0; m < Q; m++) {
      string[] dims = Console.ReadLine().Split(' ');
      lr[m,0] = Convert.ToInt64(dims[0]); // L 
      lr[m,1] = Convert.ToInt64(dims[1]); // R
    }

    // for each testcase Q
    for (long i = 0; i < Q; i++) {
      // string[] dims = Console.ReadLine().Split(' ');
      // normalise the indexing from 1 to zero
      //long L = Convert.ToInt64(dims[0]);
      long L = lr[i,0];
      L--;
      //long R = Convert.ToInt64(dims[1]);
      long R = lr[i,1];
      R--;
      long count = R - L + 1; // number of items in subarray
      long mean = 0;
      if (L == 0) {
        mean = cumSum[R] / count;
      } else {
        mean = (cumSum[R] - cumSum[L - 1]) / count;
      }
      Console.WriteLine(mean);
    }
  }
}
