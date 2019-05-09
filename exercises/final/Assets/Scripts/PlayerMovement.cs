using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 50f;
    public CharacterController characterController;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            characterController.Move(transform.forward * Time.deltaTime * 50f);
        }


    }
}


