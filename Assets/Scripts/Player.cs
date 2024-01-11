using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    bool isLaserUpgraded = true;
    bool isGunUpgraded = true;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public bool IsGunUpgraded(){
        return isGunUpgraded;
    }

    public bool IsLaserUpgraded(){
        return isLaserUpgraded;
    }
}
