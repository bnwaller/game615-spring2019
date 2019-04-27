using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Start ()
    {
       
    }

    void Update()
    {
        if (Input.GetKey("up"))
        {
            transform.Translate(0, 0, .05f);
        }
        if (Input.GetKey("down"))
        {
            transform.Translate(0, 0, -.05f);
        }
        if (Input.GetKey("left"))
        {
            transform.Rotate(0, -5f, 0);
        }
        if (Input.GetKey("right"))
        {
            transform.Rotate(0, 5f, 0);
        }

    }

}
