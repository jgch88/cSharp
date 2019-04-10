using System;

class ladder {
  public static void Main (string[] args) {
    int n = Convert.ToInt32(Console.ReadLine());

    ladder l = new ladder();
    l.printLegs();

    for (int i = 0; i < n; i++) {
      Console.WriteLine("*****");
      l.printLegs();
    }

  }

  private void printLegs() {
    Console.WriteLine("*   *");
    Console.WriteLine("*   *");
  }
}
