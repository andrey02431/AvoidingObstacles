using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    private float moveSpeed = 10f;
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("-------------Instructions-------------");
        Debug.Log("Use arrow keys or a/d to move left and right");
        Debug.Log("Use up and down arrow keys or w/s to move forwards and backwards");
        Debug.Log("Enjoy your Game !!!! :)");
    }

    void MovePlayer()
    {
        float xValue = -(Input.GetAxis("Horizontal") * Time.deltaTime) * moveSpeed;
        float yValue = 0.0f;
        float zValue = -(Input.GetAxis("Vertical") * Time.deltaTime) * moveSpeed;
        transform.Translate(xValue, yValue, zValue);
    }
    
}
