using System;
using System.Collections;

public class Seat 
{
  public Hashtable seatMap;
  public Hashtable oppositeMap;
  
  public Seat() 
  {
    seatMap = new Hashtable();
    // The seats have a snaking pattern that repeats every 12 seats
    seatMap.Add("1", "WS");
    seatMap.Add("2", "MS");
    seatMap.Add("3", "AS");
    seatMap.Add("4", "AS");
    seatMap.Add("5", "MS");
    seatMap.Add("6", "WS");
    seatMap.Add("7", "WS");
    seatMap.Add("8", "MS");
    seatMap.Add("9", "AS");
    seatMap.Add("10", "AS");
    seatMap.Add("11", "MS");
    seatMap.Add("12", "WS");

    oppositeMap = new Hashtable();
    oppositeMap.Add(1, 12);
    oppositeMap.Add(2, 11);
    oppositeMap.Add(3, 10);
    oppositeMap.Add(4, 9);
    oppositeMap.Add(5, 8);
    oppositeMap.Add(6, 7);
    oppositeMap.Add(7, 6);
    oppositeMap.Add(8, 5);
    oppositeMap.Add(9, 4);
    oppositeMap.Add(10, 3);
    oppositeMap.Add(11, 2);
    oppositeMap.Add(12, 1);
  }

  public static void Main(string[] args)
  {
    string T = Console.ReadLine();
    int t = Int32.Parse(T);
    Seat seat = new Seat();

    for (int i = 0; i < t; i++) {
      string N = Console.ReadLine();
      int n = Int32.Parse(N);
      int modN = Int32.Parse(N) % 12;
      string strModN = n.ToString();
      if (modN == 0) {
        modN = 12;
      }
      int difference = n - modN;
      int oppositeSeat = (int) seat.oppositeMap[modN];
      string actualOppositeSeat = (oppositeSeat + difference).ToString();

      Console.WriteLine(actualOppositeSeat + " " + seat.seatMap[oppositeSeat.ToString()]);
    }
  }
}
