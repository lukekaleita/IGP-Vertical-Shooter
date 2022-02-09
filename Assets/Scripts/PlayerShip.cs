using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            TakeDamage();
        }
    }

    [ContextMenu("Damage")]
    public void TakeDamage()
    {
        PlayerHealth.SetHealth(PlayerHealth.GetHealth()-1);
    }
}
