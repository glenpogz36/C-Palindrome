using System;
using System.Collections.Generic;


  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a phrase to check if it's a Palindrome");
     string wordEntered = Console.ReadLine();
     string split = "";
    for (int i = (wordEntered.Length - 1); i >= 0; i-=1)
    {
      split += wordEntered [i];
    }
    if (wordEntered == split)
    {
         Console.WriteLine("It's a Palindrome"); 
    }
   else 
    { 
      Console.WriteLine("It's Not a Palindrome");
   }

  }
}

