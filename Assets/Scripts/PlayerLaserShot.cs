using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLaserShot : MonoBehaviour
{
    
    public Transform middleGun;
    public LineRenderer line;

    void Start()
    {
        
    }


    void Update()
    {
        if(Input.GetMouseButtonDown(1)){
            RaycastHit2D hit = Physics2D.Raycast(middleGun.position, Vector2.up);

            if(hit.collider){
                Debug.Log(hit.collider.gameObject.name);

                LineRenderer laser = Instantiate(line, middleGun.position, Quaternion.identity);

                laser.SetPosition(0, middleGun.position);
                laser.SetPosition(1, hit.point);
            }
        }
    }
}
