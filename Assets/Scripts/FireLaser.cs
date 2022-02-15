using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FireLaser : MonoBehaviour
{
    [SerializeField] private Transform spawnLocation;

    [SerializeField] private GameObject laserPrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            Fire();
        }
        
    }

    private void Fire()
    {
        Instantiate(laserPrefab, spawnLocation.position, spawnLocation.rotation);
    }
    
}
