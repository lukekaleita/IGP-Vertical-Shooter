using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] private Image[] heartImages;
    [SerializeField] private int numSegments = 4;
    [SerializeField] private AudioSource damageSound;
    private void OnEnable()
    {
        PlayerHealth.HealthChanged += OnHealthChanged;
        OnHealthChanged(PlayerHealth.GetHealth());
    }

    private void OnDisable()
    {
        PlayerHealth.HealthChanged -= OnHealthChanged;
    }

    void OnHealthChanged(int health)
    {
        //Debug.Log("Health" + health);
        
        damageSound.Play();
        
        for (int i = 0; i < heartImages.Length; i++)
        {
            heartImages[i].fillAmount = (health - i * numSegments) / (float) numSegments;
        }
        
        
        
    }
}
