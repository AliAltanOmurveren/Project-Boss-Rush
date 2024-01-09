using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrusterLine : MonoBehaviour
{

    LineRenderer line;

    float minDuration = 0.1f;
    float maxDuration = 0.3f;


    
    void Start()
    {
        line = GetComponent<LineRenderer>();

        StartCoroutine(MoveLineDown(Random.Range(minDuration, maxDuration)));
    }


    void Update()
    {
        
    }

    IEnumerator MoveLineUp(float duration){
        float t = 0;

        while(t < 1){
            t += Time.deltaTime / duration;

            line.SetPosition(1, new Vector3(0, Mathf.Lerp(-1, Random.Range(-0.5f, -0.2f), t), 0));

            yield return null;
        }

        StartCoroutine(MoveLineDown(Random.Range(minDuration, maxDuration)));
    }

    IEnumerator MoveLineDown(float duration){
        float t = 0;

        while(t < 1){
            t += Time.deltaTime / duration;

            line.SetPosition(1, new Vector3(0, Mathf.Lerp(Random.Range(-0.5f, -0.2f), -1, t), 0));

            yield return null;
        }

        StartCoroutine(MoveLineUp(Random.Range(minDuration, maxDuration)));
    }
}
