using System;
using System.Collections.Generic;

class best {
  public static void Main(string[] args) {
    int N = Convert.ToInt32(Console.ReadLine());
    string[] arrayS = Console.ReadLine().Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
    long[] A = new long[N];
    long[] cumSum = new long[N];

    int[] noOfElementsToSumAtIndex = countOfElementsToSum(N);

    long max = long.MinValue;

    for (int x = 0; x < N; x++) {
      A[x] = Convert.ToInt64(arrayS[x]);
      if (x == 0) {
        cumSum[x] = A[x];
      } else {
        cumSum[x] = cumSum[x-1] + A[x];
      }
    }

    for (int y = 0; y < N; y++) {
      long special = specialSum(y, y + noOfElementsToSumAtIndex[y] - 1, cumSum);
      if (special > max) {
        max = special;
      }

    }
    Console.WriteLine(max);
    
    // calculate specialsum for index
  }

  private static long specialSum(int idx, int endIdx, long[] cumSum) {
    // specialsum = Cumsum of index to index + count - (cumsum of index - 1)
    if (idx == 0) {
      return cumSum[endIdx];
    } else {
      return cumSum[endIdx] - cumSum[idx - 1];
    }
  }

  private static int[] countOfElementsToSum(int n) {
    // e.g if n = 5, we want an array of [3, 3, 3, 1, 1] returned
    int[] noOfElementsToSumAtIndex = new int[n]; 

    // figure out "chunks"
    int count = 0;
    int sum = 1;

    Dictionary<int, int> indexCount = new Dictionary<int, int>();

    while (count < n) {
      count += sum;
      indexCount.Add(sum, count);
      sum++;
    }

    sum--;

    for (int i = 0; i < n; i++) {
      // fill array from the front
      int currCount;
      indexCount.TryGetValue(sum, out currCount);
      if (currCount > (n - i)) {
        sum--;
        indexCount.TryGetValue(sum, out currCount);
      }

      noOfElementsToSumAtIndex[i] = currCount;

    }

    return noOfElementsToSumAtIndex;
  }
}
