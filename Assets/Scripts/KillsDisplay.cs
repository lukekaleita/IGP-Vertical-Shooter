using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KillsDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;

    private void Start()
    {
        DisplayKills(KillCounter.GetKills());
    }

    private void OnEnable()
    {
        KillCounter.KillsIncreased += DisplayKills;
        DisplayKills(KillCounter.GetKills());
    }

    private void OnDisable()
    {
        KillCounter.KillsIncreased -= DisplayKills;
    }
    
    void DisplayKills(int kills) 
    {
        text.text = kills.ToString();
    }
}
