using System;

class roy {
  public static void Main(string[] args) {
    int L = Convert.ToInt32(Console.ReadLine());
    int N = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < N; i++) {
      string[] dims = Console.ReadLine().Split(' ');
      int W = Convert.ToInt32(dims[0]);
      int H = Convert.ToInt32(dims[1]);

      if (W < L || H < L) {
        Console.WriteLine("UPLOAD ANOTHER");
      } else {
        if (W == H) {
          Console.WriteLine("ACCEPTED");
        } else {
          Console.WriteLine("CROP IT");
        }
      }
    }
  }
}
