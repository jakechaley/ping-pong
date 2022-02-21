using System;
using System.Collections.Generic;
using Ping;



public class Program
{
  public static void Main()
  {
    Console.WriteLine("Enter a number: ");
    string stringUserInput = Console.ReadLine();
    int userInput = int.Parse(stringUserInput);
  
    List<string> PingList = PingPong.MakePingPong(userInput);
    

    foreach (string turn in PingList)
    {
      Console.WriteLine(turn);
    }
  }
}