using System;
using System.Collections.Generic;
class MainClass {
  public static void Main (string[] args) {
   var fibNumbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };
   int count = 0;
   foreach (int element in fibNumbers)
{
    count++;
    Console.WriteLine($"Element #{count}: {element}");
}
  }
}
