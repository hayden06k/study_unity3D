using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    Rigidbody rb;
    public float bfPower = 10000.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * bfPower);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
