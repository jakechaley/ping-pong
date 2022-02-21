using System;
using System.Collections.Generic;

namespace Ping
{

  public class PingPong
  {
    public static List<string> MakePingPong(int userInput)
    {
      var pingList = new List<string>();

      for (int i = 1; i <= userInput; i++)
      {
        if (i % 3 == 0 && i % 5 == 0)
        {
          pingList.Add("ping-pong");
        }
        else if (i % 3 == 0)
        {
          pingList.Add("ping");
        }
        else if (i % 5 == 0)
        {
          pingList.Add("pong");
        }
        else
        {
          var item = i.ToString();
          pingList.Add(item);
        } 
      }
      return pingList;
    }
  }
}