using System;

class duration {
  public static void Main(string[] args) {
    int n = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < n; i++) {
      string time = Console.ReadLine();
      string[] splitTime = time.Split(' ');
      DateTime t1 = new DateTime(2019, 1, 1, Convert.ToInt32(splitTime[0]), Convert.ToInt32(splitTime[1]), 0);
      DateTime t2 = new DateTime(2019, 1, 1, Convert.ToInt32(splitTime[2]), Convert.ToInt32(splitTime[3]), 0);

      TimeSpan ts = t2 - t1;

      // Console.WriteLine(t1 + " " + t2);
      Console.WriteLine(ts.ToString(@"%h\ %m"));
    }

  }
}
