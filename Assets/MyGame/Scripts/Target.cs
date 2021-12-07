using System.Numerics;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public GameObject target;
    public int xPos;
    public int yPos;
    public int targetCount;

    private void OnMouseDown()
    {
        Destroy(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TargetDrop());
    }


    IEnumerator TargetDrop()
    {
        while (targetCount < 10)
        {
            xPos = Random.Range(1, 50);
            yPos = Random.Range(1, 30);
            Instantiate(target, new Vector3(xPos, yPos, 0), Quaternion.identity);
            yield return new WaitForSeconds(2f);
            targetCount += 1;


        }


    }
}
