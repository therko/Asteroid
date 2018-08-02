using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed;
    public float accelerationFactor;

    void Start ()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * speed;


    }

    void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(GetComponent<Rigidbody>().velocity * speed * accelerationFactor);

        //GetComponent<Rigidbody>().velocity = transform.forward * speed * Mathf.Exp(GetComponent<Rigidbody>().velocity.z);
    }

}
