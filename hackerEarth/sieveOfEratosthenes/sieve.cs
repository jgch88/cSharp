using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

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

    // Filter out multiples5
    while (currentPrime != list[list.Count - 1]) {
      list = list.Where(p => (p % currentPrime != 0) || (p == currentPrime)).ToList();
      index++;
      currentPrime = list[index];
    }

  }

  public static void Main(string[] args)
  {
    Stopwatch stopWatch = new Stopwatch();
    stopWatch.Start();
    sieve sieve = new sieve(100000);
    stopWatch.Stop();

    Console.WriteLine(string.Join(" ", sieve.list));
    Console.WriteLine(stopWatch.Elapsed);
  }
}
