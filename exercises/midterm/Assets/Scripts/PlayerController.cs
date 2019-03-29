using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Text countText;
    public CharacterController characterController;
    private int count;

    void Start()
    {
      count = 0;
      SetCountText ();
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

    void OnTriggerEnter(Collider other)
    {
            if (other.gameObject.CompareTag("Pick Up"))
            {
                other.gameObject.SetActive (false);
                count = count + 1;
                SetCountText ();
            }
    }

    void SetCountText ()
    {
        countText.text = "Count: " + count.ToString ();
    }
}
    
        

