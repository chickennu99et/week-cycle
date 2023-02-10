using System;
using System.Threading;

class Program {
  static void Main (string[] args) {
    int day = 1;
    int week = 0;
    while (day<=14){
    Console.Clear();
    Console.WriteLine("week: " + week);
    switch(day)
      {
      case 1:
        Console.WriteLine("sunday");
        break;
      case 2:
        Console.WriteLine("night");
        break;
      case 3:
        Console.WriteLine("monday");
        break;
      case 4:
        Console.WriteLine("night");
        break;
      case 5:
        Console.WriteLine("tuesday");
        break;
      case 6:
        Console.WriteLine("night");
        break;
      case 7:
        Console.WriteLine("wendsday");
        break;
      case 8:
        Console.WriteLine("night");
        break;
      case 9:
        Console.WriteLine("thursday");
        break;
      case 10:
        Console.WriteLine("night");
        break;
      case 11:
        Console.WriteLine("friday");
        break;
      case 12:
        Console.WriteLine("night");
        break;
      case 13:
        Console.WriteLine("saturday");
        break;
      case 14:
        Console.WriteLine("night");
        break;
      }
      Thread.Sleep(60000);
      if(++day>14)
      {
        day = 1;
        week++;
      }
    }
  }
}