using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MugnusEffects : MonoBehaviour
{
    private Rigidbody rb;
    public Vector3 angularV, v;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }// Start


    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.angularVelocity = angularV;
            rb.velocity = v;
        }

        rb.AddForce(Vector3.Cross(rb.angularVelocity, rb.velocity));

    }//FixedUpdate
}
