using System;
using System.Linq;

public class anagram {

  public static void Main(string[] args) {
    int t = Int32.Parse(Console.ReadLine());

    for (int i = 0; i < t; i++) {
      string s1 = Console.ReadLine();
      string s2 = Console.ReadLine();

      string sortedS1 = new string (s1.OrderBy(c => c).ToArray());
      string sortedS2 = new string (s2.OrderBy(c => c).ToArray());
      int index1 = 0;
      int index2 = 0;

      int deletedCharacters = 0;
      
      // sort both strings
      // compare the strings at each index, and walk the smaller one forward
      // add 1 to deleted characters
      // if the strings are the same, walk both forward.
      // keep walking until one reaches the end, then delete the remaining characters
      // of the string that hasn't walked to the end
    
      do {
        if ((sortedS1[index1].CompareTo(sortedS2[index2]) == 0)) {
          index1++;
          index2++;
        } else if (sortedS1[index1].CompareTo(sortedS2[index2]) < 0) {
          index1++;
          deletedCharacters++;
        } else if (sortedS2[index2].CompareTo(sortedS1[index1]) > 0) {
          index2++;
          deletedCharacters++;
        }
        // Console.WriteLine(index1 + " " + index2 + " " + deletedCharacters);
      } while (!((index1 == sortedS1.Length) || (index2 == sortedS2.Length)));

      if (index1 == sortedS1.Length) {
        deletedCharacters += (sortedS2.Length - index2);
      } else if (index2 == sortedS2.Length) {
        deletedCharacters += (sortedS1.Length - index1);
      }

      Console.WriteLine(deletedCharacters);

    }
  }
}
