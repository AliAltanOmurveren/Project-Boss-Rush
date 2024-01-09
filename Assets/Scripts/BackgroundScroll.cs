using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    public float scrollSpeed;
    Vector3 startPos;
    
    void Start()
    {
        startPos = transform.position;
    }


    void Update()
    {
        transform.Translate(-transform.up * scrollSpeed * Time.deltaTime);

        if(transform.position.y <= startPos.y - 20){
            transform.position = startPos;
        }

    }
}
