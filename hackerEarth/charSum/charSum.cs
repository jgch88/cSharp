using System;

class charSum {
  public static void Main(string[] args) {
    string s = Console.ReadLine();

    int sum = 0;
    for (int i = 0; i < s.Length; i++) {
      sum += (Convert.ToInt32(s[i]) - 96);
    }
    Console.WriteLine(sum);
  }
}
