using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    private void OnEnable()
    {
        PlayerHealth.HealthChanged += KillPlayer;
        KillPlayer(PlayerHealth.GetHealth());
    }

    private void KillPlayer(int health)
    {
        if (health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}



