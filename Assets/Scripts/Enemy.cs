using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float respawnY = 10;
    [SerializeField] private GameObject explosionPrefab;
    private float _respawnX;
    private Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        _respawnX = transform.position.x;
    }

    public void Respawn()
    {
        gameObject.SetActive(true);
        transform.position = new Vector2(_respawnX, respawnY);
        _rigidbody2D.velocity = Vector2.zero;
    }

    private void OnMouseDown()
    {
        //Debug.Log("down");
        Despawn();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Laser"))
        {
            Despawn();
        }
    }

    private void Despawn()
    {
        gameObject.SetActive(false);
        GameManager.instance.UnListEnemy(gameObject);
        Instantiate(explosionPrefab, transform.position, transform.rotation);
    }
}
