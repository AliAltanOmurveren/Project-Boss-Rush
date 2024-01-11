using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLaserShot : MonoBehaviour
{
    
    public Transform middleGun;
    public Transform leftGun;
    public Transform rightGun;

    public LineRenderer line;

    Player player;

    void Start()
    {
        player = GetComponent<Player>();
    }


    void Update()
    {
        if(Input.GetMouseButtonDown(1)){
            if (player.IsLaserUpgraded()){
                LaserShot(leftGun);
                LaserShot(middleGun);
                LaserShot(rightGun);
            }else{
                LaserShot(middleGun);
            }
        }
    }

    void LaserShot(Transform gunPos){
        RaycastHit2D hit = Physics2D.Raycast(gunPos.position, Vector2.up);

        if(hit.collider){
            LineRenderer laser = Instantiate(line, gunPos.position, Quaternion.identity);

            laser.SetPosition(0, gunPos.position);
            laser.SetPosition(1, hit.point);
        }else{
            LineRenderer laser = Instantiate(line, gunPos.position, Quaternion.identity);

            laser.SetPosition(0, gunPos.position);
            laser.SetPosition(1, gunPos.position + Vector3.up * 10);
        }
    }
}
