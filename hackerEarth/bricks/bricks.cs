using System;

class bricks {
  public static void Main(string[] args) {
    int N = Convert.ToInt32(Console.ReadLine());

    int i = 1;
    int sum = 0;
    int overflowSum = 0;
    // add 3i bricks to figure out which stage their no. of bricks overflow N
    while (sum < N) {
      sum += (3*i);
      i++;
      if (sum > N) {
        overflowSum = sum;
        sum -= (3*(i-1));
        int difference = N - sum;
        if (difference <= (overflowSum - sum)/3) {
          Console.WriteLine("Patlu");
          break;
        } else {
          Console.WriteLine("Motu");
          break;
        }
      }
    }
    
  }
}
