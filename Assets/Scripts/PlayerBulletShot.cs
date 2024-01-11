using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletShot : MonoBehaviour
{
    
    public GameObject bulletPrefab;

    public Transform middleGun;
    public Transform leftGun;
    public Transform RightGun;

    Player player;

    public float shootDelay;

    void Start()
    {
        player = GetComponent<Player>();
    }


    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            StartCoroutine(Shoot());
        }
    }

    IEnumerator Shoot(){
        float t = shootDelay;

        bool canShoot = true;

        while(Input.GetMouseButton(0)){
            t -= Time.deltaTime;

            if(t <= 0){
                canShoot = true;
            }

            if(canShoot){
                canShoot = false;
                t = shootDelay;

                if(player.IsGunUpgraded()){
                    Instantiate(bulletPrefab, leftGun.position, Quaternion.identity);
                    Instantiate(bulletPrefab, middleGun.position, Quaternion.identity);
                    Instantiate(bulletPrefab, RightGun.position, Quaternion.identity);
                }else{
                    Instantiate(bulletPrefab, middleGun.position, Quaternion.identity);
                }
            }

            yield return null;
        }
    }
}
