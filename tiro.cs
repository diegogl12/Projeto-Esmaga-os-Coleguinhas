using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiro : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter(Collider outro)
    {
        Destroy(gameObject);
    }
}
