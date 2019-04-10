using System;

class FindProduct {
  public static void Main(string[] args) {
    string[] nk = Console.ReadLine().Split(' ');
    long n = Convert.ToInt64(nk[0]);
    long k = Convert.ToInt64(nk[1]);

    string[] numlist = Console.ReadLine().Split(' ');
    long[] nums = new long[n];
    for (long i = 0; i < n; i++) {
      nums[i] = Convert.ToInt64(numlist[i]);
    }

    long minCost = Int64.MaxValue;

    for (long j = 0; j < n; j++) {

      if (nums[j] == 0) {
        continue;
      }

      long l = j+k; // everytime j increases, j+k may burst
      if (j + k > n - 1) {
        l = n - 1;
      }

      

      while (l > j) {
        // if they are not same signs, collapse them
         // Console.WriteLine("j " + j + " " + nums[j]);
         // Console.WriteLine("l " + l + " " + nums[l]);
        if (!((Math.Abs(nums[j]) + Math.Abs(nums[l])) == Math.Abs(nums[j] + nums[l]))) {
          long smaller;
          long larger;
          if (Math.Abs(nums[j]) <= Math.Abs(nums[l])) {
            smaller = j;
            larger = l;
          } else {
            smaller = l;
            larger = j;
          }
          nums[larger] += nums[smaller];
          nums[smaller] = 0;
          l--;
        } else {
          break;
        }
        /*
        if (nums[l] > 0) {
          break;
        }
        // Console.WriteLine("j " + j + " " + nums[j]);
        // Console.WriteLine("l " + l + " " + nums[l]);
        if (nums[l] <= 0) {
          if (nums[j] >= Math.Abs(nums[l])) {
            nums[j] -= Math.Abs(nums[l]);
            nums[l] = 0;
          } else {
            nums[l] += nums[j];
            nums[j] = 0;
          }
        }
        */
      }

      long cost = 0;
      for (long m = 0; m < n; m++) {
        cost += Math.Abs(nums[m]);
      }
      if (cost < minCost) {
        minCost = cost;
      }
      // Console.WriteLine(string.Join(",", nums));
      // Console.WriteLine("cost " + cost);
    }

    

    Console.WriteLine(minCost);
  }
}
