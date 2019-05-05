using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropBallScript : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name.Equals("Sphere"))
            rb.isKinematic = false;
    }
     void onCollisionEnter(Collision col)
    {
        if (col.gameObject.name.Equals("Sphere"))
            Debug.Log("Got you!");
    }
}
