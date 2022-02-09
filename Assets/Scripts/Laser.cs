using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float lifeTime = 1f;

    private float _life = 0f;
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = (transform.up * speed);
    }

    // Update is called once per frame
    void Update()
    {
        _life += Time.deltaTime;
        if (_life >= lifeTime)
        {
            Destroy(gameObject);
        }
    }
}
