using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPitch : MonoBehaviour
{ 
    AudioSource source;
    Rigidbody rb;
    float speed;

    void Start()
    {
        source = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        source.pitch = (float)(rb.velocity.magnitude * 1.5);
        speed = rb.velocity.magnitude;


    }
}
