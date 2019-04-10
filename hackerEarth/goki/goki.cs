using System;

public class goki {
  public static void Main(string[] args) {
    int n = Convert.ToInt32(Console.ReadLine());
    int x = Convert.ToInt32(Console.ReadLine());
    
    for (int i = 0; i < n; i++) {
      int y = Convert.ToInt32(Console.ReadLine());
      if (y >= x) {
        Console.WriteLine("YES");
      } else {
        Console.WriteLine("NO");
      }
    }
  }
}
