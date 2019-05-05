using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(-Input.GetAxis("Vertical") * 2, 0, 0);
        transform.Rotate(0, 0, Input.GetAxis("Horizontal") * 2);
    }
}
