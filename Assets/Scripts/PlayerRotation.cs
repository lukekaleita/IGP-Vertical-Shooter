using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private Camera mainCamera;
    
    void Update()
    {
        RotatePlayerToMouse();
    }

    private void RotatePlayerToMouse()//Rotates Player Towards Mouse
    {
        Vector2 mouseDirection = mainCamera.ScreenToWorldPoint(Input.mousePosition) - transform.position; 
        float angle = Mathf.Atan2(mouseDirection.x, mouseDirection.y) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.back);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);
    }
}
