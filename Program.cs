using System;

namespace ConsoleApp1 {
 class Program {
  static void Main () {
   const int n = 5;
   double [] arr = new double [n] { 4,5,5,5,5 };
   double max = Double.MinValue, max2 = Double.MinValue;
   foreach (var i in arr) {
    if (i > max) {
     max2 = max; max = i;
    }
    else if (i > max2 && i < max) max2 = i;
   }
   Console.WriteLine ($"max={max}");
   if (max2 != Double.MinValue) Console.WriteLine ($"max2={max2}");
   else Console.WriteLine ("max2 not found");
   Console.ReadLine ();
  }
 }
}   