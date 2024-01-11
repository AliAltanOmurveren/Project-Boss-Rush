using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    Rigidbody2D rb;
    public float bulletSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.AddForce(transform.up * bulletSpeed, ForceMode2D.Impulse);
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Destroy(gameObject);
    }
}
