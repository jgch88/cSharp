using System;


class naive {
  public static void Main(string[] args) {
    int n = Convert.ToInt32(Console.ReadLine());
    string[] list = Console.ReadLine().Split(' ');
    long[] nums = new long[n];
    for (int i = 0; i < n; i++) {
      nums[i] = Convert.ToInt64(list[i]);
    }

    long ans = 1;
    for (int j = 0; j < n; j++) {
      ans = (ans * nums[j]) % (1000000000 + 7);
    }

    Console.WriteLine(ans);

  }
}
