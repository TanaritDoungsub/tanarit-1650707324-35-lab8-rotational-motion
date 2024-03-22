using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    private Rigidbody rb;
    public Vector3 angularV, torque;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.AddTorque(torque);
        }
        if (Input.GetMouseButtonDown(1))
        {
            rb.angularVelocity = angularV;
        }
    }

}
