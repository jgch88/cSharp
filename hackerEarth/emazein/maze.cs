using System;

class maze {
  public static void Main(string[] args) {
    string path = Console.ReadLine();
    int x = 0;
    int y = 0;

    for (int i = 0; i < path.Length; i++) {
      if (path[i] == 'L') {
        x -= 1;
      } else if (path[i] == 'R') {
        x += 1;
      } else if (path[i] == 'U') {
        y += 1;
      } else if (path[i] == 'D') {
        y -= 1;
      }
    }

    Console.WriteLine(x + " " + y);
  }
}
