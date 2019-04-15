using System;
using System.Collections.Generic;
using System.Linq;

class pmNo {
  public static void Main(string[] args) {


    string[] nums = Console.ReadLine().Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
    int a = Convert.ToInt32(nums[0]);
    int b = Convert.ToInt32(nums[1]);

    List<int> l = generatePrimes(b);
    List<int> pmsPrimes = new List<int>();

    l.ForEach(prime => {
      if (prime >= a) {
        int primeCpy = prime;
        int sumDigits = 0;
        while (primeCpy != 0) {
          sumDigits += primeCpy % 10;
          primeCpy /= 10;
        }
        if (l.Contains(sumDigits)) {
          pmsPrimes.Add(prime);
        }
      }
    });
    Console.WriteLine(String.Join(" ", pmsPrimes.ToArray()));
  }

  static List<int> generatePrimes(int n) {
    List<int> list = new List<int>();
    int currentPrime = 2;
    int index;

    for (int i = 0; i < n-1; i++) {
      list.Add(i + currentPrime);
    }

    index = 0;

    int sqrt = (int) Math.Sqrt(n) + 1; // To optimise, we only need to find the primes up to sqrt(n)
    // Filter out multiples
    while (currentPrime <= sqrt) {
    // https://www.quora.com/What-is-the-segmented-sieve-of-Eratosthenes
    // while (currentPrime != list[list.Count - 1]) {
      // list = list.Where(p => (p % currentPrime != 0) || (p == currentPrime)).ToList();
      for (int j = list.Count() - 1; j >= 0; j--) {
        if (list[j] % currentPrime == 0 && list[j] != currentPrime) {
          list.Remove(list[j]);
        }
      }
      index++;
      currentPrime = list[index];
    }

    return list;
  }
}
