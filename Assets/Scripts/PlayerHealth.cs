using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerHealth
{
    public static event Action<int> HealthChanged;
    private static int _health = 12;

    public static int GetHealth()
    {
        return _health;
    }
    public static void SetHealth(int health)
    {
        if (_health == health)
            return;
        _health = health;
        HealthChanged?.Invoke(_health);
    }
    
}
