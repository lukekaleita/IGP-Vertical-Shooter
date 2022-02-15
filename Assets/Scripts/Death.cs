using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    /*void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            LoadNextScene();
        }
    }*/
    private void OnEnable()
    {
        PlayerHealth.HealthChanged += CheckIfDead;
        CheckIfDead(PlayerHealth.GetHealth());
    }
    private void OnDisable()
    {
        PlayerHealth.HealthChanged -= CheckIfDead;
    }

    private void CheckIfDead(int health)
    {
        if (health <= 0)
        {
            LoadNextScene();
        }
    }
    

    private void LoadNextScene()
    {
        //Debug.Log("Loaded Next Scene");
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    
}



