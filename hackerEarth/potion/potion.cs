using System;

class potion {
  public static void Main(string[] args) {
    string isbn = Console.ReadLine();
    int sum = 0;

    for (int i = 0; i < isbn.Length; i++) {
      sum += Convert.ToInt32(isbn[i]) * (i+1);
    }

    if (sum % 11 == 0) {
      Console.WriteLine("Legal ISBN");
    } else {
      Console.WriteLine("Illegal ISBN");
    }
  }
}
