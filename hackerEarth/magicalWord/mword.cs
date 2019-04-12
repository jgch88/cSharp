using System;
using System.Text;
using System.Collections.Generic;

class mword {
  public static void Main(string[] args) {
    int T = Convert.ToInt32(Console.ReadLine());
    // get primes within range of ASCII alphabet values (65 - 90), (97 - 122)
    
    Dictionary<int, char> magicCharDict = new Dictionary<int, char>();
    magicCharDict.Add(67, 'C');
    magicCharDict.Add(71, 'G');
    magicCharDict.Add(73, 'I');
    magicCharDict.Add(79, 'O');
    magicCharDict.Add(83, 'S');
    magicCharDict.Add(89, 'Y');
    magicCharDict.Add(97, 'a');
    magicCharDict.Add(101, 'e');
    magicCharDict.Add(103, 'g');
    magicCharDict.Add(107, 'k');
    magicCharDict.Add(109, 'm');
    magicCharDict.Add(113, 'q');

    for (int i = 0; i < T; i++) {
      int L = Convert.ToInt32(Console.ReadLine());
      string S = Console.ReadLine();

      StringBuilder magicWord = new StringBuilder();

      // for each letter
      for (int j = 0; j < S.Length; j++) {
        // convert letter to ascii value
        int nearest = lowestNearestPrime((int) S[j]);
        // find closest lower prime
        // concatenate lower prime's alphabet
        char magicChar;
        magicCharDict.TryGetValue(nearest, out magicChar);
        magicWord.Append(magicChar);

      }

      Console.WriteLine(magicWord.ToString());
    }

  }

  static int lowestNearestPrime(int asciiVal) {
    // e.g. if asciiVal = 69, return 67
    if (asciiVal <= 69) {
      return 67;
    } else if (asciiVal <= 72) {
      return 71;
    } else if (asciiVal <= 76) {
      return 73;
    } else if (asciiVal <= 81) {
      return 79;
    } else if (asciiVal <= 86) {
      return 83;
    } else if (asciiVal <= 93) {
      return 89;
    } else if (asciiVal <= 99) {
      return 97;
    } else if (asciiVal <= 102) {
      return 101;
    } else if (asciiVal <= 105) {
      return 103;
    } else if (asciiVal <= 108) {
      return 107;
    } else if (asciiVal <= 111) {
      return 109;
    } else {
      return 113;
    }

  }
}
