using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int day = 2;
      switch (day) 
      {
        case 2:
          Console.WriteLine("Today is Monday.");
          break;
        case 3:
          Console.WriteLine("Today is Thursday.");
          break;
        default:
          Console.WriteLine("Looking forward to NextWeek.");
          break;
      }    
    }
  }
}
