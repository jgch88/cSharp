using System;
using System.Collections.Generic;

class twoStrings {
  public static void Main(string[] args) {
    int t = Convert.ToInt32(Console.ReadLine());

    Dictionary<char, int> counts = new Dictionary<char, int>();

    for (int i = 0; i < t; i++) {
      string bothStrings = Console.ReadLine();
      // The strings will be separated in the middle if S1.Length == S2.Length
      // 0123 4 5678
      int index1 = 0;
      int index2 = bothStrings.Length / 2 + 1; // int division will floor

      // as we walk through the strings, increment the hashmap if spotted in s1, 
      // and decrement the hashmap if in s2
      while (index2 < bothStrings.Length) {
        // counts.Add("a", counts[bothStrings[index1]] + 1);
        int c1 = 0;
        counts.TryGetValue(bothStrings[index1], out c1);
        c1++;
        counts.Remove(bothStrings[index1]);
        counts.Add(bothStrings[index1], c1);

        int c2 = 0;
        counts.TryGetValue(bothStrings[index2], out c2);
        c2--;
        counts.Remove(bothStrings[index2]);
        counts.Add(bothStrings[index2], c2);

        index1++;
        index2++;
      }
      // at the end, if s1 == s2, then values should all be 0
      string result = "YES";
      foreach(KeyValuePair<char, int> kvp in counts) {
        // Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
        if (kvp.Value != 0) {
          result = "NO";
          break;
        }
      }
      Console.WriteLine(result);
    }
  }

}
