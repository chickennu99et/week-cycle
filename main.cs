using System;
using System.Threading;

class Program {
  static void Main (string[] args) {
    int day = 1;
    int week = 0;
    while (day<=7){
    Console.Clear();
    Console.WriteLine("week: " + week);
    switch(day)
      {
      case 1:
      Console.WriteLine("sunday");
        break;
      case 2:
      Console.WriteLine("monday");
        break;
      case 3:
      Console.WriteLine("tuesday");
        break;
      case 4:
      Console.WriteLine("wendsday");
        break;
      case 5:
      Console.WriteLine("thursday");
        break;
      case 6:
      Console.WriteLine("friday");
        break;
      case 7:
      Console.WriteLine("saturday");
        break;
      }
      Thread.Sleep(1000);
      if(++day>7)
      {
        day = 1;
        week++;
      }
    }
  }
}