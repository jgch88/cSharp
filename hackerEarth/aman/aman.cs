using System;

class aman {
  public static void Main(string[] args) {
    int d = Convert.ToInt32(Console.ReadLine());
    int toffees = 0;
    for (int i = 0; i < d; i++) {
      string[] dims = Console.ReadLine().Split(' ');
      long r = Convert.ToInt64(dims[0]);
      long x = Convert.ToInt64(dims[1]);

      if ((x * 700) > ((22) * 2 * r)) { //!! take note of 22/7 floating point causing errors! static typed languages have this problem, compare ints on both sides!
      // using float(r), float(x) still doesn't work
        toffees += 1;
      }

    }

    Console.WriteLine(toffees);
  }
}
