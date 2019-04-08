using System;
using System.Collections.Generic;
using System.Linq;

public class sieve
{
  public List<int> list;
  private int currentPrime;
  private int index;

  public sieve(int n)
  {

    // Initialise Array to sieve
    currentPrime = 2;

    list = new List<int>();
    for (int i = 0; i < n-1; i++) {
      list.Add(i + currentPrime);
    }

    index = 0;

    // Filter out multiples
    while (currentPrime != list[list.Count - 1]) {
      list = list.Where(p => (p % currentPrime != 0) || (p == currentPrime)).ToList();
      index++;
      currentPrime = list[index];
    }

  }

  public static void Main(string[] args)
  {
    string n = Console.ReadLine();
    sieve sieve = new sieve(Int32.Parse(n));
    Console.WriteLine(string.Join(" ", sieve.list));
  }
}
