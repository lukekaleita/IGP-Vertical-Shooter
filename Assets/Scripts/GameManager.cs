using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private GameObject[] enemyArray;
    [SerializeField] private List<GameObject> activeEnemyList;
    [SerializeField] private AudioSource explosionSound;
    
    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        enemyArray = GameObject.FindGameObjectsWithTag("Enemy");
        
        activeEnemyList = new List<GameObject>(enemyArray);
    }

    public void UnListEnemy(GameObject enemy)
    {
        explosionSound.Play();
        activeEnemyList.Remove(enemy);
        
        if (activeEnemyList.Count == 0)
        {
            ResetAllEnemies();
        }
    }

    private void ResetAllEnemies()
    {
        foreach (var enemy in enemyArray)
        {
            enemy.GetComponent<Enemy>().Respawn();
            activeEnemyList.Add(enemy);
        }
    }
}
