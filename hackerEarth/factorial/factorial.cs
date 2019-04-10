using System;

class factorial {
  public static void Main(string[] args) {
    int n = Convert.ToInt32(Console.ReadLine());

    long f = 1;

    for (int i = 1; i <= n; i++) {
      f *= i;
    }

    Console.WriteLine(f);

  }
}
