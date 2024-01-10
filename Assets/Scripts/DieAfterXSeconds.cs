using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieAfterXSeconds : MonoBehaviour
{

    public float lifetimeDuration;
    
    void Start()
    {
        Destroy(gameObject, lifetimeDuration);
    }

    void Update()
    {
        
    }
}
