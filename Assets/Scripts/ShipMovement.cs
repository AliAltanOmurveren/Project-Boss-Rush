using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public float xMin;
    public float xMax;

    public float yMin;
    public float yMax;

    void Start()
    {
        Cursor.visible = false;
    }


    void Update()
    {
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        transform.position = new Vector3(Mathf.Clamp(mouseWorldPos.x, xMin, xMax), Mathf.Clamp(mouseWorldPos.y, yMin, yMax), 0);
    }
}
