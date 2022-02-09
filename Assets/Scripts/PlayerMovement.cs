using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   private Vector2 _input;
   [SerializeField] private Vector2 moveSpeed;
   [SerializeField] private float boundsLeft = -5;
   [SerializeField] private float boundsRight = 5;
   [SerializeField] private float boundsUp = -2f;
   [SerializeField] private float boundsDown = -15f;
   private Rigidbody2D _rb;
   private void Awake()
   {
      _rb = GetComponent<Rigidbody2D>();
   }
   
   private void Update()
   {
      _input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
   }

   private void FixedUpdate()
   {
      _rb.velocity = _input * moveSpeed;

      Vector2 position = transform.position;

      position.x = Mathf.Clamp(position.x, boundsLeft, boundsRight);
      position.y = Mathf.Clamp(position.y, boundsDown, boundsUp);

      transform.position = position;
   }
}



