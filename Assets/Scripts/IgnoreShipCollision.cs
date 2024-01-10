using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreShipCollision : MonoBehaviour
{
    
    GameObject ship;

    void Start()
    {
        ship = GameObject.FindGameObjectWithTag("Player");

        Physics2D.IgnoreCollision(ship.GetComponent<Collider2D>(), gameObject.GetComponent<Collider2D>());
    }


    void Update()
    {
        
    }
}
