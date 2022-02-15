using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StoreTime
{
    private static float _time = 0f;
    
    public static float GetTime()
    {
        _time += Time.deltaTime;
        return _time;
    }
    public static float GetFinalTime()
    {
        return _time;
    }
}
