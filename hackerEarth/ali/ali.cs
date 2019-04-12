using System;

class ali {
  public static void Main(string[] args) {
    string t = Console.ReadLine();
    // check letter
    char l = t[2];
    string result = "valid";
    if (l == 'A' || l == 'E' || l == 'I' || l == 'O' || l == 'U' || l == 'Y') {
      result = "invalid";
    }

    if ((Convert.ToInt32(t[0]) + Convert.ToInt32(t[1])) % 2 != 0) {
      result = "invalid";
    }

    if ((Convert.ToInt32(t[3]) + Convert.ToInt32(t[4])) % 2 != 0) {
      result = "invalid";
    }

    if ((Convert.ToInt32(t[4]) + Convert.ToInt32(t[5])) % 2 != 0) {
      result = "invalid";
    }

    if ((Convert.ToInt32(t[7]) + Convert.ToInt32(t[8])) % 2 != 0) {
      result = "invalid";
    }

    Console.WriteLine(result);
  }
}
