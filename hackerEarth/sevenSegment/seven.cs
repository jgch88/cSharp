using System;
using System.Text;
using System.Collections.Generic;

class seven {
  public static void Main(string[] args) {
    int T = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < T; i++) {
      string N = Console.ReadLine();
      Console.WriteLine(maxValueFromSticks(noOfSticksFrom(N)));
    }

  }
  
  private static string maxValueFromSticks(int s) {
    // assume s is at least 2
    //
    // for even sticks make a string of 1s, for odd sticks make a string of 1s then 7
    StringBuilder sb = new StringBuilder();
    if (s % 2 == 0) {
      for (int i = 0; i < (s/2); i++) {
        sb.Append("1");
      }
    } else {
      // 7 = 2+2 + 3 = 117
      sb.Append("7");
      for (int i = 0; i < (s/2) - 1; i++) {
        sb.Append("1");
      }
    }

    return sb.ToString();
  }

  
  private static int noOfSticksFrom(string n) {
    int sticks = 0;
    Dictionary<char, int> sticksRequired = new Dictionary<char, int>();
    sticksRequired.Add('0', 6);
    sticksRequired.Add('1', 2);
    sticksRequired.Add('2', 5);
    sticksRequired.Add('3', 5);
    sticksRequired.Add('4', 4);
    sticksRequired.Add('5', 5);
    sticksRequired.Add('6', 6);
    sticksRequired.Add('7', 3);
    sticksRequired.Add('8', 7);
    sticksRequired.Add('9', 6);

    // can see here that we want to utilise 2 sticks for '1', or 3 sticks for '7'

    int val;
    for (int i = 0; i < n.Length; i++) {
      sticksRequired.TryGetValue(n[i], out val);
      sticks += val;
    }
    return sticks;
  }
}
