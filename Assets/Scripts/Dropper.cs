using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{

    [SerializeField] private float waitingTime = 3.0f;

    private MeshRenderer renderer;

    private Rigidbody gravity;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        gravity = GetComponent<Rigidbody>();
        gravity.useGravity = false;
        renderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > waitingTime)
        {
            renderer.enabled = true;
            gravity.useGravity = true;
        }
    }
}
