using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class KillCounter
{
   public static event Action<int> KillsIncreased;
   private static int _kills = 0;
   
   public static int GetKills() { return _kills; }

   public static void IncrementKills()
   {
      _kills++;
      KillsIncreased?.Invoke(_kills);
   }

}
