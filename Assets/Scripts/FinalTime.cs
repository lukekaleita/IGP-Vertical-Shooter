using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinalTime : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    void Start()
    {
        DisplayTime(StoreTime.GetFinalTime());
    }
    void DisplayTime(float timeToDisplay) //Displays Time on the timer as a formatted string
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        text.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
