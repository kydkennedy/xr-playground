using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceOnStart : MonoBehaviour
{
    public Rigidbody body;
    public float power;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        body.AddForce(transform.forward * power);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
