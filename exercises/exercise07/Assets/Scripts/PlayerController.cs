using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController characterController;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            characterController.Move(transform.forward * Time.deltaTime * 50.0f);
        }
        //Input.GetAxis("Vertical"), 0.0f, -Input.GetAxis("Horizontal")
        transform.Rotate(0, Input.GetAxis("Horizontal") * 5, 0);

        characterController.Move(new Vector3(0, Input.GetAxis("Vertical") * 2, 0));
    }
}
    
        

